using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MinimapIconInternalStruct
{
	[FieldOffset(0)]
	public long IconNamePtr;

	[FieldOffset(8)]
	public int MinimapIconRadius;

	[FieldOffset(12)]
	public int LargemapIconRadius;

	[FieldOffset(19)]
	public int MinimapIconPointerMaxDistance;
}
