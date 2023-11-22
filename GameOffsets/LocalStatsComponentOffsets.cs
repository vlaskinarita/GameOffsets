using System.Runtime.InteropServices;
using GameOffsets.Components;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LocalStatsComponentOffsets
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(32)]
	public StdVector StatsPtr;
}
