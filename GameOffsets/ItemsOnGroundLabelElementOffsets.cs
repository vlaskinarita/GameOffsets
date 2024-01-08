using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemsOnGroundLabelElementOffsets
{
	public const int SecondConfigOffset = 936;

	[FieldOffset(512)]
	public long ConfigPtr;

	[FieldOffset(528)]
	public StdVector VisibleItemLabels;

	[FieldOffset(672)]
	public long LabelOnHoverPtr;

	[FieldOffset(680)]
	public long ItemOnHoverPtr;

	[FieldOffset(696)]
	public long LabelsOnGroundListPtr;

	[FieldOffset(704)]
	public long LabelCount;

	[FieldOffset(768)]
	public long LabelCount2;
}
