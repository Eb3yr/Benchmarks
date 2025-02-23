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

		[Params(23, 135, 517, 1023, 2051, 2563, 65533, 1_000_003)]	// Non-powers of 4, prevent optimal case for vectors
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
		}

		[Benchmark]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public T Trapz()
		{
			T result = T.Zero;
		
			for (int i = 0; i < x.Length - 1; i++)
				result += (y[i + 1] + y[i]) * (x[i + 1] - x[i]);
		
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
		
		[Benchmark]
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
			Span<T> dest = x.Length <= 2048 ? stackalloc T[x.Length - 1] : new T[x.Length - 1];
			Span<T> xDiff = x.Length <= 2048 ? stackalloc T[x.Length - 1] : new T[x.Length - 1];
			Span<T> _x = x;
			Span<T> _y = y;
		
			TensorPrimitives.Subtract(_x.Slice(1, _x.Length - 1), _x.Slice(0, _x.Length - 1), xDiff);
			TensorPrimitives.Add(_y.Slice(1, _x.Length - 1), _y.Slice(0, _x.Length - 1), dest);
			TensorPrimitives.Multiply(dest, xDiff, dest);
			return TensorPrimitives.Sum<T>(dest) / (T.One + T.One);
		}

		[Benchmark]
		public T TrapzTensorPrimitivesSlidingWindow()
		{
			// Avoid heap allocation by re-using a smaller stackalloc destination array
			const int stackLim = 1024;   // 2^n + 1 to keep dest, xDiff lengths powers of 2. 
			int remainder = x.Length;
			T result = T.Zero;
			int minOfLength = int.Min(x.Length - 1, stackLim);
			Span<T> dest = stackalloc T[minOfLength];
			Span<T> xDiff = stackalloc T[minOfLength];
			Span<T> _x = x;
			Span<T> _y = y;

			int offset = 0;
			while (remainder > stackLim)
			{
				TensorPrimitives.Subtract(_x.Slice(1 + offset, stackLim), _x.Slice(offset, stackLim), xDiff);
				TensorPrimitives.Add(_y.Slice(1 + offset, stackLim), _y.Slice(offset, stackLim), dest);
				TensorPrimitives.Multiply(dest, xDiff, dest);
				result += TensorPrimitives.Sum<T>(dest);

				offset += stackLim;
				remainder -= stackLim;
			}

			// We slice the destinations so that the lengths all match
			TensorPrimitives.Subtract(_x.Slice(1 + offset, remainder - 1), _x.Slice(offset, remainder - 1), xDiff.Slice(0, remainder - 1));
			TensorPrimitives.Add(_y.Slice(1 + offset, remainder - 1), _y.Slice(offset, remainder - 1), dest.Slice(0, remainder - 1));
			TensorPrimitives.Multiply(dest.Slice(0, remainder - 1), xDiff.Slice(0, remainder - 1), dest.Slice(0, remainder - 1));
			result += TensorPrimitives.Sum<T>(dest.Slice(0, remainder - 1));
			return result / Two;
		}

		[Benchmark(Baseline = true)]
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

					result += Vector.Sum(
						Vector.Multiply(
							Vector.Subtract(vecXPlusOne, vecX),
							Vector.Add(vecY, vecYPlusOne)
							)
						);

					remainder -= Vector<T>.Count;
					i += Vector<T>.Count;
				}

				while (i < Length - 1)
					result += (yPtr[i + 1] + yPtr[i]) * (xPtr[i + 1] - xPtr[i++]);
			}

			return result / Two;
		}

		[Benchmark]
		public T TrapzOptimal()
		{
			const int threshold = 2048;
		
			if (Length < threshold)
				return TrapzVectors();
		
			return TrapzTensorPrimitivesSlidingWindow();
		}
	}
}
