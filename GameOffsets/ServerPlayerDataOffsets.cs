using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerPlayerDataOffsets
{
	[FieldOffset(400)]
	public NativePtrArray PassiveSkillIds;

	[FieldOffset(624)]
	public byte PlayerClass;

	[FieldOffset(628)]
	public int CharacterLevel;

	[FieldOffset(632)]
	public int PassiveRefundPointsLeft;

	[FieldOffset(636)]
	public int QuestPassiveSkillPoints;

	[FieldOffset(640)]
	public int FreePassiveSkillPointsLeft;

	[FieldOffset(644)]
	public int TotalAscendencyPoints;

	[FieldOffset(652)]
	public int SpentAscendencyPoints;
}
