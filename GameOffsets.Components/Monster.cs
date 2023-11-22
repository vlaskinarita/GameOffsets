using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Monster
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(24)]
	public long MonsterInternalPtr;
}
