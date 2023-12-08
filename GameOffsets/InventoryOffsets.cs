using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InventoryOffsets
{
	public const int DefaultServerInventoryOffset = 1264;

	public const int ComplexStashFirstLevelServerInventoryOffset = 96;

	public const int DivinationServerInventoryOffset = 888;

	public const int BlightServerInventoryOffset = 976;

	[FieldOffset(600)]
	public long HoverItem;

	[FieldOffset(608)]
	public Vector2i FakePos;

	[FieldOffset(616)]
	public int XFake;

	[FieldOffset(620)]
	public int YFake;

	[FieldOffset(616)]
	public Vector2i RealPos;

	[FieldOffset(624)]
	public int XReal;

	[FieldOffset(628)]
	public int YReal;

	[FieldOffset(632)]
	public int CursorInInventory;

	[FieldOffset(952)]
	public long ItemCount;

	[FieldOffset(1296)]
	public Vector2i InventorySize;

	[FieldOffset(1148)]
	public int TotalBoxesInInventoryRow;
}
