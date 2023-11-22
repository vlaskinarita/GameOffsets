using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Chest
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(88)]
	public long ChestInternalPtr;

	[FieldOffset(376)]
	public bool IsOpened;

	[FieldOffset(377)]
	public bool IsLocked;

	[FieldOffset(380)]
	public byte Quality;

	[FieldOffset(176)]
	public byte Rarity;
}
