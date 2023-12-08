using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NormalInventoryItemOffsets
{
	[FieldOffset(896)]
	public long Item;

	[FieldOffset(1044)]
	public int InventPosX;

	[FieldOffset(1048)]
	public int InventPosY;

	[FieldOffset(1052)]
	public int Width;

	[FieldOffset(1056)]
	public int Height;
}
