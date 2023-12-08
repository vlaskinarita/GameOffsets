using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StashTabContainerOffsets
{
	[FieldOffset(2424)]
	public long TabSwitchBarPtr;

	[FieldOffset(2448)]
	public long ViewAllStashesButtonPtr;

	[FieldOffset(2464)]
	public long PinStashTabListButtonPtr;

	[FieldOffset(2544)]
	public int VisibleStashIndex;
}
