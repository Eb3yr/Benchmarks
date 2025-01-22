using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace StructPacking
{
	[MemoryDiagnoser(true)]
	public class ReadBench
    {
		Ordered ordered;
		OrderedPackOne orderedPack1;
		Jumbled jumbled;
		JumbledPackOne jumbledPack1;

		byte _b;
		int _i;
		long _l;

		[Benchmark(Baseline = true)]
		public void ReadOrdered()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_l = ordered.l;
				_i = ordered.i;
				_b = ordered.b;
			}
		}

		[Benchmark]
		public void ReadOrderedPack1()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_l = orderedPack1.l;
				_i = orderedPack1.i;
				_b = orderedPack1.b;
			}
		}

		[Benchmark]
		public void ReadOrderedReverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_b = ordered.b;
				_i = ordered.i;
				_l = ordered.l;
			}
		}

		[Benchmark]
		public void ReadOrderedPack1Reverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_b = orderedPack1.b;
				_i = orderedPack1.i;
				_l = orderedPack1.l;
			}
		}

		[Benchmark]
		public void ReadJumbled()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_b = jumbled.b;
				_l = jumbled.l;
				_i = jumbled.i;
			}
		}

		[Benchmark]
		public void ReadJumbledPack1()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_b = jumbledPack1.b;
				_l = jumbledPack1.l;
				_i = jumbledPack1.i;
			}
		}

		[Benchmark]
		public void ReadJumbledReverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_i = jumbled.i;
				_l = jumbled.l;
				_b = jumbled.b;
			}
		}

		[Benchmark]
		public void ReadJumbledPack1Reverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				_i = jumbledPack1.i;
				_l = jumbledPack1.l;
				_b = jumbledPack1.b;
			}
		}
	}
}
