using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModsComponentStatsOffsets
{
	[FieldOffset(8)]
	public StdVector ImplicitStatsArray;

	[FieldOffset(72)]
	public StdVector EnchantedStatsArray;

	[FieldOffset(200)]
	public StdVector CrucibleStatsArray;

	[FieldOffset(264)]
	public StdVector ExplicitStatsArray;

	[FieldOffset(328)]
	public StdVector CraftedStatsArray;

	[FieldOffset(392)]
	public StdVector FracturedStatsArray;
}
