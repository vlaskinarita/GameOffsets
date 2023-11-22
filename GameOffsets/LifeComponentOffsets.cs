using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LifeComponentOffsets
{
	[FieldOffset(8)]
	public long Owner;

	[FieldOffset(456)]
	public VitalStruct Mana;

	[FieldOffset(512)]
	public VitalStruct EnergyShield;

	[FieldOffset(376)]
	public VitalStruct Health;
}
