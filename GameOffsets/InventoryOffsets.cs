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

	[FieldOffset(592)]
	public int ItemHoverState;

	[FieldOffset(600)]
	public long HoverItem;

	[FieldOffset(608)]
	public Vector2i FakePos;

	[FieldOffset(616)]
	public Vector2i RealPos;

	[FieldOffset(632)]
	public int CursorInInventory;

	[FieldOffset(952)]
	public long ItemCount;

	[FieldOffset(1296)]
	public Vector2i InventorySize;

	[FieldOffset(1336)]
	public long CursorPtr;
}
