using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InventoryInternalStruct
{
	[FieldOffset(0)]
	public long ItemName;

	[FieldOffset(8)]
	public long ItemTexture;

	[FieldOffset(16)]
	public long ItemModel;
}
