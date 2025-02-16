using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Numerics.Tensors;

namespace ArraySum
{
	[MemoryDiagnoser(true)]
	public class Benchmarks
	{
		float[] vals;

		[Params(8, 128, 4096, 65536, 1048576)]
		public int Length;

		public Benchmarks()
		{
			vals = new float[Length];
			Random rng = new(0);
			for (int i = 0; i < vals.Length; i++)
				vals[i] = rng.NextSingle();
		}

		[Benchmark(Baseline = true)]
		public float SumFor()
		{
			float sum = 0;
			for (int i = 0; i < vals.Length; i++)
				sum += vals[i];
		
			return sum;
		}
		
		[Benchmark]
		public float SumLinq()
		{
			return vals.Sum();
		}

		[Benchmark]
		public float SumVector()
		{
			ReadOnlySpan<float> vals = new(this.vals);
			float sum = 0;
			int i = 0;
			while (i < vals.Length - Vector<float>.Count)
			{
				sum += Vector.Sum(new Vector<float>(vals.Slice(i, Vector<float>.Count)));
				i += Vector<float>.Count;
			}
			Span<float> final = stackalloc float[Vector<float>.Count];
			vals.Slice(i).CopyTo(final);
			sum += Vector.Sum(new Vector<float>(final));

			return sum;
		}

		[Benchmark]
		public unsafe float SumIntrinsics()
		{
			ReadOnlySpan<float> vals = new(this.vals);
			float sum = 0;
			int i = 0;
			while (i < vals.Length - Vector256<float>.Count)
			{
				sum += Vector256.Sum(Vector256.LoadUnsafe(ref MemoryMarshal.GetReference(vals.Slice(i, Vector256<float>.Count))));
				i += Vector256<float>.Count;
			}

			Span<float> final = stackalloc float[Vector256<float>.Count];
			vals.Slice(i).CopyTo(final);
			sum += Vector256.Sum(Vector256.LoadUnsafe(ref MemoryMarshal.GetReference(final)));

			return sum;
		}

		[Benchmark]
		public unsafe float SumIntrinsicsPinned()
		{
			ReadOnlySpan<float> vals = new(this.vals);
			float sum = 0;

			int i = 0;
			fixed (float* ptr = vals)
			{
				while (i < vals.Length - Vector256<float>.Count)
				{
					sum += Vector256.Sum(Vector256.Load(ptr + i));
					i += Vector256<float>.Count;
				}
			}

			Span<float> final = stackalloc float[Vector256<float>.Count];
			vals.Slice(i).CopyTo(final);
			sum += Vector256.Sum(Vector256.LoadUnsafe(ref MemoryMarshal.GetReference(final)));

			return sum;
		}

		[Benchmark]
		public float SumTensorPrimitives()
		{
			ReadOnlySpan<float> vals = new(this.vals);
			return TensorPrimitives.Sum(vals);
		}

		[Benchmark]
		public float SumTensor()
		{
#pragma warning disable SYSLIB5001
			ReadOnlyTensorSpan<float> vals = new(this.vals);
			return Tensor.Sum(vals);
		}
	}
}
