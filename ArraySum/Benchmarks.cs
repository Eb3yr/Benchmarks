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

		[Params(8, 128, 4096, 65536/*, 1048576*/)]
		public int Length;

		[GlobalSetup]
		public void GlobalSetup()
		{
			vals = new float[Length];
			Random rng = new(0);
			for (int i = 0; i < vals.Length; i++)
				vals[i] = rng.NextSingle();
		}

		[Benchmark]
		public float SumFor()
		{
			float sum = 0;
			for (int i = 0; i < vals.Length; i++)
				sum += vals[i];
		
			return sum;
		}
		
		//[Benchmark]
		//public float SumLinq()	// Slower than SumFor()
		//{
		//	return vals.Sum();
		//}

		[Benchmark(Baseline = true)]
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

			foreach (float f in vals.Slice(i))
				sum += f;

			return sum;
		}

		[Benchmark]
		public unsafe float SumVector256()
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

			foreach (float f in vals.Slice(i))
				sum += f;

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
