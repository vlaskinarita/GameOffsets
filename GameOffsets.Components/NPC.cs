using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPC
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(24)]
	public long NpcInternalPtr;

	[FieldOffset(32)]
	public bool IsMapLabelVisible;

	[FieldOffset(72)]
	public long IconOverheadPtr;
}
