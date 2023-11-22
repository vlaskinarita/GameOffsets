using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AttributeRequirements
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(16)]
	public long RequirementsInternalPtr;
}
