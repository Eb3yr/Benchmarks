using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StructPacking
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Ordered
	{
		public long l;
		public int i;
		public byte b;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct OrderedPackOne
	{
		public long l;
		public int i;
		public byte b;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct Jumbled
	{
		public byte b;
		public long l;
		public int i;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct JumbledPackOne
	{
		public byte b;
		public long l;
		public int i;
	}
}
