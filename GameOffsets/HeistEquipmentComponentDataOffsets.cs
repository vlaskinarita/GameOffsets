using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistEquipmentComponentDataOffsets
{
	[FieldOffset(24)]
	public long HeistEquipmentKey;
}
