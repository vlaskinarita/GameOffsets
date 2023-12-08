using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StashElementOffsets
{
	public const int StashTabContainerOffset2 = 680;

	[FieldOffset(712)]
	public long StashTitlePanelPtr;

	[FieldOffset(720)]
	public long ExitButtonPtr;

	[FieldOffset(768)]
	public long StashTabContainerPtr1;
}
