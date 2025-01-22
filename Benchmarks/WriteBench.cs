using BenchmarkDotNet.Attributes;
using StructPacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPacking
{
	[MemoryDiagnoser(true)]
	public class WriteBench
	{
		Ordered ordered;
		OrderedPackOne orderedPack1;
		Jumbled jumbled;
		JumbledPackOne jumbledPack1;

		[Benchmark(Baseline = true)]
		public void WriteOrdered()
		{
			for (int i = 0; i < 1_000; i++)
			{
				ordered.l = 1;
				ordered.i = 1;
				ordered.b = 1;
			}
		}

		[Benchmark]
		public void WriteOrderedPack1()
		{
			for (int i = 0; i < 1_000; i++)
			{
				orderedPack1.l = 1;
				orderedPack1.i = 1;
				orderedPack1.b = 1;
			}
		}

		[Benchmark]
		public void WriteOrderedReverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				ordered.b = 1;
				ordered.i = 1;
				ordered.l = 1;
			}
		}

		[Benchmark]
		public void WriteOrderedPack1Reverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				orderedPack1.b = 1;
				orderedPack1.i = 1;
				orderedPack1.l = 1;
			}
		}

		[Benchmark]
		public void WriteJumbled()
		{
			for (int i = 0; i < 1_000; i++)
			{
				jumbled.b = 1;
				jumbled.l = 1;
				jumbled.i = 1;
			}
		}

		[Benchmark]
		public void WriteJumbledPack1()
		{
			for (int i = 0; i < 1_000; i++)
			{
				jumbledPack1.b = 1;
				jumbledPack1.l = 1;
				jumbledPack1.i = 1;
			}
		}

		[Benchmark]
		public void WriteJumbledReverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				jumbled.i = 1;
				jumbled.l = 1;
				jumbled.b = 1;
			}
		}

		[Benchmark]
		public void WriteJumbledPack1Reverse()
		{
			for (int i = 0; i < 1_000; i++)
			{
				jumbledPack1.i = 1;
				jumbledPack1.l = 1;
				jumbledPack1.b = 1;
			}
		}
	}
}
