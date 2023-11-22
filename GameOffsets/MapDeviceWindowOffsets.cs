using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapDeviceWindowOffsets
{
	[FieldOffset(720)]
	public long BottomPanelPtr;
}
