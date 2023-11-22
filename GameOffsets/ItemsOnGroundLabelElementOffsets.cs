using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemsOnGroundLabelElementOffsets
{
	[FieldOffset(648)]
	public long LabelOnHoverPtr;

	[FieldOffset(656)]
	public long ItemOnHoverPtr;

	[FieldOffset(672)]
	public long LabelsOnGroundListPtr;
}
