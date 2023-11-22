using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SubStatsComponentOffsets
{
	[FieldOffset(240)]
	public StdVector Stats;
}
