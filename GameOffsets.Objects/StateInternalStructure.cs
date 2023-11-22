using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Objects;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StateInternalStructure
{
	[FieldOffset(0)]
	public byte StateEnumToName;

	[FieldOffset(8)]
	public IntPtr StatePtr;
}
