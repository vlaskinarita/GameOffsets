using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistEquipmentComponentOffsets
{
	[FieldOffset(8)]
	public long OwnerKey;

	[FieldOffset(16)]
	public long DataKey;
}
