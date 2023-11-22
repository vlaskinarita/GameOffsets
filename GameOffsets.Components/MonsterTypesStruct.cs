using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterTypesStruct
{
	[FieldOffset(0)]
	public long IdStringPtr;

	[FieldOffset(12)]
	public bool IsSummoned;

	[FieldOffset(13)]
	public int Armour;

	[FieldOffset(17)]
	public int Evasion;

	[FieldOffset(21)]
	public int EnergyShield;

	[FieldOffset(25)]
	public int MovementSpeed;

	[FieldOffset(29)]
	public long TotalTagsKeys;

	[FieldOffset(37)]
	public long TagsKeys;

	[FieldOffset(53)]
	public long MonsterResistancesPtr;
}
