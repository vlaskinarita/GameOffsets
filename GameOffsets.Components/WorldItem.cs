using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldItem
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(32)]
	public long ItemPtr;

	[FieldOffset(48)]
	public int LootAllocationId;

	[FieldOffset(52)]
	public uint LootAllocationTime;

	[FieldOffset(56)]
	public int DroppedTime;

	[FieldOffset(56)]
	public float Unknown0;

	[FieldOffset(64)]
	public byte Unknown1;

	[FieldOffset(65)]
	public byte Unknown2;
}
