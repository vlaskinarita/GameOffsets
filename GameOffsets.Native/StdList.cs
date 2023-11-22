using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdList
{
	public IntPtr Head;

	public ulong Size;
}
