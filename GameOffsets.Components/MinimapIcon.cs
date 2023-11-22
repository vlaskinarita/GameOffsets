using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MinimapIcon
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(40)]
	public long MinimapIconInternalPtr;

	[FieldOffset(52)]
	public byte IsHidden;
}
