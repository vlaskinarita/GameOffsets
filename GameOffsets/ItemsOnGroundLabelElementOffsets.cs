using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemsOnGroundLabelElementOffsets
{
	[FieldOffset(672)]
	public long LabelOnHoverPtr;

	[FieldOffset(680)]
	public long ItemOnHoverPtr;

	[FieldOffset(696)]
	public long LabelsOnGroundListPtr;
}
