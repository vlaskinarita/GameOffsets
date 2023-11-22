using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TriggerableBlockage
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(48)]
	public byte IsClosed;
}
