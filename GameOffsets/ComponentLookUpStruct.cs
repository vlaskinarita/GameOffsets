using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ComponentLookUpStruct
{
	[FieldOffset(40)]
	public nint ComponentArray;

	[FieldOffset(72)]
	public long Capacity;

	[FieldOffset(80)]
	public long Count;
}
