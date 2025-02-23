using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Numerics.Tensors;

namespace TrapeziumRule
{
	[MemoryDiagnoser(true)]
	public unsafe class Benchmarks<T> where T : unmanaged, INumberBase<T>, IFloatingPoint<T>
	{
		T[] x;
		T[] y;

		static readonly T Two = T.One + T.One;
		static readonly T half = T.One / Two;

		[Params(23, 135, 517, 1023, 2051, 65533, 1_000_003)]	// Non-powers of 4, prevent optimal case for vectors
		public int Length;

		private static T F(T x) => x * x + T.One;

		[GlobalSetup]
		public void GlobalSetup()
		{
			x = new T[Length];
			T counter = T.Zero;
			for (int i = 0; i < Length; i++)
				x[i] = counter++;

			y = new T[Length];
			for (int i = 0; i < x.Length; i++)
				y[i] = F(x[i]);

			T tLen = (T)Convert.ChangeType(Length, typeof(T));
			T expected = tLen * tLen * tLen / (Two + T.One) + tLen;
			T oneHundred = (T)Convert.ChangeType(100f, typeof(T));
			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine($"Length: {Length}\tExpected: {expected}. Actual: {Trapz()}, Ptr: {TrapzPtrUnrolled()}. Error: {oneHundred - oneHundred * Trapz() / expected}%");
			if (TrapzPtrUnrolled() != TrapzVectors())
			{
				Console.WriteLine($"Mismatch: Analytical: {Length * Length * Length / 3 + Length}, TrapzPtr: {TrapzPtrUnrolled()}, Vectorised: {TrapzVectors()}");
				Task.Delay(3000).Wait();
			}
			Console.BackgroundColor = ConsoleColor.Gray;
		}

		[Benchmark]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public T Trapz()
		{
			T result = T.Zero;

			for (int i = 0; i < x.Length - 1; i++)  // I could do this with IEnumerable because I'm just iterating each one
				result += (y[i + 1] + y[i]) * (x[i + 1] - x[i]);  // 0.5(a+b)h

			return half * result;
		}

		[Benchmark]
		public unsafe T TrapzPtr()
		{
			T result = T.Zero;

			fixed (T* xPtr = x)
			fixed (T* yPtr = y)
			{
				int i = 0;
				while (i < x.Length - 1)
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
			}
			result /= T.One + T.One;

			return result;
		}

		[Benchmark(Baseline = true)]
		public unsafe T TrapzPtrUnrolled()
		{
			T result = T.Zero;

			fixed (T* xPtr = x)
			fixed (T* yPtr = y)
			{
				int i = 0;
				int remainder = (x.Length - 1) / 4;

				while (remainder > 0)
				{
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
					remainder -= 4;
				}

				while (i < x.Length - 1)
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
			}
			result /= (T.One + T.One);

			return result;
		}

		[Benchmark]
		public T TrapzTensorPrimitives()
		{
			T result = T.Zero;
			Span<T> dest = x.Length <= 1024 ? stackalloc T[x.Length - 1] : new T[x.Length - 1];
			Span<T> xDiff = x.Length <= 1024 ? stackalloc T[x.Length - 1] : new T[x.Length - 1];
			Span<T> _x = x;
			Span<T> _y = y;

			TensorPrimitives.Subtract(_x.Slice(1), _x.Slice(0, _x.Length - 1), xDiff);
			TensorPrimitives.Subtract(_y.Slice(1), _y.Slice(0, _x.Length - 1), dest);
			TensorPrimitives.Multiply(dest, xDiff, dest);
			return TensorPrimitives.Sum<T>(dest) / (T.One + T.One);
		}

		[Benchmark]
		public unsafe T TrapzVectors()
		{
			T result = T.Zero;

			fixed (T* xPtr = x)
			fixed (T* yPtr = y)
			{
				int i = 0;
				int remainder = (Length - 1) / Vector<T>.Count;
				Vector<T> vecX, vecY, vecXPlusOne, vecYPlusOne;
				while (remainder > 0)
				{
					vecX = Vector.Load(xPtr + i);
					vecXPlusOne = Vector.Load(xPtr + i + 1);
					vecY = Vector.Load(yPtr + i);
					vecYPlusOne = Vector.Load(yPtr + i + 1);

					result += Vector.Sum(Vector.Multiply(Vector.Add(vecY, vecYPlusOne), Vector.Subtract(vecXPlusOne, vecX)));   // This feels smelly

					remainder -= Vector<T>.Count;
					i += Vector<T>.Count;
				}

				while (i < Length - 1)
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
			}

			return result / Two;
		}
	}
}
