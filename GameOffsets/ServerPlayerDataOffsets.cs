using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerPlayerDataOffsets
{
	[FieldOffset(400)]
	public NativePtrArray PassiveSkillIds;

	[FieldOffset(608)]
	public byte PlayerClass;

	[FieldOffset(612)]
	public int CharacterLevel;

	[FieldOffset(616)]
	public int PassiveRefundPointsLeft;

	[FieldOffset(620)]
	public int QuestPassiveSkillPoints;

	[FieldOffset(624)]
	public int FreePassiveSkillPointsLeft;

	[FieldOffset(620)]
	public int TotalAscendencyPoints;

	[FieldOffset(632)]
	public int SpentAscendencyPoints;
}
