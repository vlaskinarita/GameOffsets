using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EntityLabelMapOffsets
{
	[FieldOffset(680)]
	public long EntityLabelMap;

	public const int LabelPtrOffset = 448;

	public const int LabelOffset = 760;
}
