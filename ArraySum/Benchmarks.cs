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

		[Params(4, 16, 128, 4096, 65536)]
		public int Length;

		[GlobalSetup]
		public void GlobalSetup()
		{
			vals = new float[Length];
			Random rng = new(0);
			for (int i = 0; i < vals.Length; i++)
				vals[i] = rng.NextSingle();

			Debug.Assert(SumPointers() == SumFor());
			Debug.Assert(SumPointersUnwound() == SumFor());
		}

		[Benchmark]
		public float SumLinq()
		{
			return vals.Sum();
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
		public float SumForeach()
		{
			float sum = 0;
			foreach (float f in vals)
				sum += f;

			return sum;
		}

		[Benchmark]
		public unsafe float SumPointers()
		{
			float sum = 0f;
			fixed (float* ptr = vals)
			{
				for (int i = 0; i < vals.Length; i++)
					sum += ptr[i];
			}
			return sum;
		}

		[Benchmark]
		public unsafe float SumPointersUnwound()
		{
			float sum = 0f;
			fixed (float* ptr = vals)
			{
				int remainder = vals.Length / 4;
				int i = 0;
				while (remainder > 0)
				{
					sum += ptr[i++];
					sum += ptr[i++];
					sum += ptr[i++];
					sum += ptr[i++];
					remainder -= 4;
				}

				for (; i < vals.Length; i++)
					sum += ptr[i];
			}
			return sum;
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
	}
}
