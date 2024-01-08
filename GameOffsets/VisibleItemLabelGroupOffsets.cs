using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 72)]
public struct VisibleItemLabelGroupOffsets
{
	[FieldOffset(0)]
	public StdVector Labels;

	[FieldOffset(24)]
	public Vector2 GroupPosition;
}
