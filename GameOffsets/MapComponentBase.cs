using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapComponentBase
{
	[FieldOffset(16)]
	public long Base;

	[FieldOffset(24)]
	public byte Tier;
}
