using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
public struct VisibleItemLabelOffsets
{
	[FieldOffset(0)]
	public long ElementPtr;

	[FieldOffset(8)]
	public Vector2 PositionOffset;

	[FieldOffset(28)]
	public uint EntityId;
}
