using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TargetableComponentOffsets
{
	[FieldOffset(72)]
	public bool isTargetable;

	[FieldOffset(73)]
	public bool isHighlightable;

	[FieldOffset(74)]
	public bool isTargeted;
}
