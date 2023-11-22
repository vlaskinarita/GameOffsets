using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Shrine
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(32)]
	public int EntityIdWhoLastPickedTheShrine;

	[FieldOffset(36)]
	public byte IsUsed;

	[FieldOffset(48)]
	public long ShrineDatRowPtr;
}
