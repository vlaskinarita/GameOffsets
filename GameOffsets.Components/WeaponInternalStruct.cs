using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponInternalStruct
{
	[FieldOffset(8)]
	public long Unknown0Ptr;

	[FieldOffset(16)]
	public int Unknown1;

	[FieldOffset(20)]
	public int minimum_damage;

	[FieldOffset(24)]
	public int maximum_damage;

	[FieldOffset(28)]
	public int weapon_speed;

	[FieldOffset(32)]
	public int critical_chance;

	[FieldOffset(36)]
	public int minimum_attack_distance;

	[FieldOffset(40)]
	public int maximum_attack_distance;
}
