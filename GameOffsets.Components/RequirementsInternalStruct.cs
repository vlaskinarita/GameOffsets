using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RequirementsInternalStruct
{
	[FieldOffset(16)]
	public int strength;

	[FieldOffset(20)]
	public int dexterity;

	[FieldOffset(24)]
	public int intelligence;
}
