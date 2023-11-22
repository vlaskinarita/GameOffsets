using System;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ComponentLookUpStruct
{
	[FieldOffset(48)]
	public IntPtr ComponentArray;

	[FieldOffset(56)]
	public long Capacity;
}
