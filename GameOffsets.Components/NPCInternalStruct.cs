using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCInternalStruct
{
	[FieldOffset(24)]
	public long NpcDatPtr;
}
