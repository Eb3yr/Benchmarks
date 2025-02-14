using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace ArraySum
{
	[MemoryDiagnoser(true)]
	public class Benchmarks
	{
		float[] vals;
		public Benchmarks()
		{
			vals = Enumerable.Range(0, 10_000).Select(x => 0.5f * x * x).ToArray();
			if (SumIntrinsics() != SumIntrinsicsPinned() || SumFor() != SumIntrinsics())
			{
				Console.WriteLine($"For: {SumFor()}");
				Console.WriteLine($"LINQ: {SumLinq()}");
				Console.WriteLine($"Vector: {SumVector()}");
				Console.WriteLine($"Intrinsics: {SumIntrinsics()}");
				Console.WriteLine($"Intrinsics pinned: {SumIntrinsicsPinned()}");
				Console.WriteLine($"Mismatch between expected and vectorised values, by {100f * (SumFor() - SumIntrinsics()) / SumFor()}%");
			}
		}

		[Benchmark]
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

		[Benchmark(Baseline = true)]
		public float SumVector()
		{
			Span<float> vals = this.vals.AsSpan();
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
			Span<float> vals = this.vals.AsSpan();
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
			Span<float> vals = this.vals.AsSpan();
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
	}
}
