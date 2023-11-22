using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MinimapIconOffsets
{
	[FieldOffset(32)]
	public long NamePtr;

	[FieldOffset(48)]
	public byte IsVisible;

	[FieldOffset(52)]
	public byte IsHide;
}
