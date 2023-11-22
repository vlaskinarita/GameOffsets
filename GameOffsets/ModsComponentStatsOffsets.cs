using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModsComponentStatsOffsets
{
	[FieldOffset(8)]
	public NativePtrArray ImplicitStatsArray;

	[FieldOffset(72)]
	public NativePtrArray EnchantedStatsArray;

	[FieldOffset(200)]
	public NativePtrArray CrucibleStatsArray;

	[FieldOffset(264)]
	public NativePtrArray ExplicitStatsArray;

	[FieldOffset(328)]
	public NativePtrArray CraftedStatsArray;

	[FieldOffset(392)]
	public NativePtrArray FracturedStatsArray;
}
