using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SubActorSkillOffsets
{
	[FieldOffset(0)]
	public ushort Id;

	[FieldOffset(8)]
	public long EffectsPerLevelPtr;

	[FieldOffset(112)]
	public byte CanBeUsedWithWeapon;

	[FieldOffset(113)]
	public byte CannotBeUsed;

	[FieldOffset(116)]
	public int TotalUses;

	[FieldOffset(128)]
	public int Cooldown;

	[FieldOffset(140)]
	public int SoulsPerUse;

	[FieldOffset(144)]
	public int TotalVaalUses;

	[FieldOffset(160)]
	public long StatsPtr;
}
