using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerInventoryOffsets
{
	[FieldOffset(320)]
	public byte InventType;

	[FieldOffset(324)]
	public byte InventSlot;

	[FieldOffset(320)]
	public byte IsRequested;

	[FieldOffset(332)]
	public int Columns;

	[FieldOffset(336)]
	public int Rows;

	[FieldOffset(368)]
	public long InventoryItemsPtr;

	[FieldOffset(392)]
	public long InventorySlotItemsPtr;

	[FieldOffset(400)]
	public long ItemCount;

	[FieldOffset(488)]
	public int ServerRequestCounter;

	[FieldOffset(504)]
	public long Hash;
}
