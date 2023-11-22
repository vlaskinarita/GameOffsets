using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InventoryOffsets
{
	public const int DefaultServerInventoryOffset = 1248;

	public const int ComplexStashFirstLevelServerInventoryOffset = 96;

	public const int DivinationServerInventoryOffset = 872;

	public const int BlightServerInventoryOffset = 960;

	[FieldOffset(584)]
	public long HoverItem;

	[FieldOffset(592)]
	public Vector2i FakePos;

	[FieldOffset(616)]
	public int XFake;

	[FieldOffset(620)]
	public int YFake;

	[FieldOffset(600)]
	public Vector2i RealPos;

	[FieldOffset(624)]
	public int XReal;

	[FieldOffset(628)]
	public int YReal;

	[FieldOffset(616)]
	public int CursorInInventory;

	[FieldOffset(936)]
	public long ItemCount;

	[FieldOffset(1280)]
	public Vector2i InventorySize;

	[FieldOffset(1148)]
	public int TotalBoxesInInventoryRow;
}
