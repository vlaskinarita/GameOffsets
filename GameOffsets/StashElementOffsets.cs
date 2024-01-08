using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StashElementOffsets
{
	public const int StashTabContainerOffset2 = 648;

	[FieldOffset(728)]
	public long StashTitlePanelPtr;

	[FieldOffset(736)]
	public long ExitButtonPtr;

	[FieldOffset(768)]
	public long StashTabContainerPtr1;
}
