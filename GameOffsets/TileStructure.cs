using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 56)]
public struct TileStructure
{
	[FieldOffset(0)]
	public long SubTileDetailsPtr;

	[FieldOffset(8)]
	public long TgtFilePtr;

	[FieldOffset(48)]
	public short TileHeight;

	[FieldOffset(54)]
	public byte RotationSelector;
}
