using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StashTabContainerOffsets
{
	[FieldOffset(2408)]
	public long TabSwitchBarPtr;

	[FieldOffset(2432)]
	public long ViewAllStashesButtonPtr;

	[FieldOffset(2448)]
	public long PinStashTabListButtonPtr;

	[FieldOffset(2528)]
	public int VisibleStashIndex;
}
