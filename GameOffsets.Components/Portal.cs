using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Portal
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(32)]
	public byte Type;

	[FieldOffset(56)]
	public long WorldAreaDatRowPtr;
}
