using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NormalInventoryItemOffsets
{
	[FieldOffset(896)]
	public long Item;

	[FieldOffset(1060)]
	public int InventPosX;

	[FieldOffset(1064)]
	public int InventPosY;

	[FieldOffset(1068)]
	public int Width;

	[FieldOffset(1072)]
	public int Height;
}
