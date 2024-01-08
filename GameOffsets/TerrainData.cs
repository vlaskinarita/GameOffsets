using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TerrainData
{
	[FieldOffset(24)]
	public ushort NumCols;

	[FieldOffset(32)]
	public ushort NumRows;

	[FieldOffset(40)]
	public NativePtrArray TgtArray;

	[FieldOffset(208)]
	public NativePtrArray LayerMelee;

	[FieldOffset(232)]
	public NativePtrArray LayerRanged;

	[FieldOffset(256)]
	public int BytesPerRow;

	[FieldOffset(260)]
	public short TileHeightMultiplier;

	private int Cols => NumCols;

	private int Rows => NumRows;
}
