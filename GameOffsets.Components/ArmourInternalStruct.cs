using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArmourInternalStruct
{
	[FieldOffset(16)]
	public int Evasion;

	[FieldOffset(20)]
	public int Armour;

	[FieldOffset(24)]
	public int EnergyShield;

	[FieldOffset(24)]
	public int IncreasedMovementSpeed;
}
