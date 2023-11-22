using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StatsComponentOffsets
{
	[FieldOffset(8)]
	public long Owner;

	[FieldOffset(32)]
	public long SubStatsPtr;
}
