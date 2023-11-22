using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistEquipmentOffsets
{
	[FieldOffset(8)]
	public long BaseItemKey;

	[FieldOffset(24)]
	public long RequiredJobKey;

	[FieldOffset(32)]
	public int RequiredJobMinimumLevel;
}
