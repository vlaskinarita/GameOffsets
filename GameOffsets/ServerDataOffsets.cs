using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataOffsets
{
	public const int Skip = 32768;

	public const int ATLAS_REGION_UPGRADES = 34930;

	public const int WaypointsUnlockStateOffset = 43529;

	public const int BetrayalDataOffset2 = 1944;

	public const int AtlasPassivesListOffset = 352;

	public const int QuestFlagsOffset = 440;

	[FieldOffset(0)]
	public long MasterAreas;

	[FieldOffset(7208)]
	public long PlayerRelatedData;

	[FieldOffset(7216)]
	public long AtlasTreeContainerPtr;

	[FieldOffset(7232)]
	public byte NetworkState;

	[FieldOffset(7272)]
	public NativeStringU League;

	[FieldOffset(7392)]
	public int TimeInGame;

	[FieldOffset(7400)]
	public int TimeInGame2;

	[FieldOffset(7424)]
	public int Latency;

	[FieldOffset(7432)]
	public NativePtrArray PlayerStashTabs;

	[FieldOffset(7456)]
	public NativePtrArray GuildStashTabs;

	[FieldOffset(5816)]
	public NativeStringU PartyLeaderName;

	[FieldOffset(5832)]
	public byte PartyStatusType;

	[FieldOffset(5856)]
	public NativePtrArray CurrentParty;

	[FieldOffset(5880)]
	public byte PartyAllocationType;

	[FieldOffset(5881)]
	public bool PartyDownscaleDisabled;

	[FieldOffset(7317)]
	public byte EaterOfWorldsCounter;

	[FieldOffset(7318)]
	public byte SearingExarchCounter;

	[FieldOffset(8064)]
	public long GuildName;

	[FieldOffset(8104)]
	public SkillBarIdsStruct SkillBarIds;

	[FieldOffset(8132)]
	public Vector2 WorldMousePosition;

	[FieldOffset(8152)]
	public long QuestFlagsPtr;

	[FieldOffset(8200)]
	public NativePtrArray NearestPlayers;

	[FieldOffset(7200)]
	public NativePtrArray EntityEffects;

	[FieldOffset(8944)]
	public NativePtrArray PlayerInventories;

	[FieldOffset(9640)]
	public NativePtrArray NPCInventories;

	[FieldOffset(10336)]
	public NativePtrArray GuildInventories;

	[FieldOffset(10696)]
	public ushort TradeChatChannel;

	[FieldOffset(10704)]
	public ushort GlobalChatChannel;

	[FieldOffset(10864)]
	public ushort LastActionId;

	[FieldOffset(9952)]
	public int CompletedMapsCount;

	[FieldOffset(10920)]
	public StdVector AncestorFightInfoList;

	[FieldOffset(11032)]
	public long CompletedMaps;

	[FieldOffset(11096)]
	public long BonusCompletedAreas;

	[FieldOffset(11720)]
	public int DialogDepth;

	[FieldOffset(11724)]
	public byte MonsterLevel;

	[FieldOffset(11725)]
	public byte MonstersRemaining;

	[FieldOffset(11906)]
	public int CurrentAzuriteAmount;

	[FieldOffset(11922)]
	public ushort CurrentSulphiteAmount;

	[FieldOffset(11296)]
	public NativePtrArray BlightLanes;

	[FieldOffset(12496)]
	public ServerDataArtifacts Artifacts;
}
