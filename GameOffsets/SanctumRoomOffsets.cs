using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumRoomOffsets
{
	public const int SanctumRoomDataInElementOffset = 800;

	public const int FightRoomOffset = 0;

	public const int RewardRoomOffset = 16;

	public const int RoomEffectOffset = 32;

	public const int RewardSize = 16;

	public const int Reward1Offset = 56;

	public const int Reward2Offset = 72;

	public const int Reward3Offset = 88;
}
