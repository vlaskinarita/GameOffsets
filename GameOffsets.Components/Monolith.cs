using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Monolith
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(112)]
	public byte OpenStage;
}
