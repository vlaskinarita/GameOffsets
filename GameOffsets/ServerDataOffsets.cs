using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataOffsets
{
	public const int Skip = 32768;

	public const int ATLAS_REGION_UPGRADES = 34930;

	public const int WaypointsUnlockStateOffset = 43657;

	public const int BetrayalDataOffset2 = 1944;

	public const int AtlasPassivesListOffset = 352;

	public const int QuestFlagsOffset = 440;

	[FieldOffset(0)]
	public long MasterAreas;

	[FieldOffset(7336)]
	public long PlayerRelatedData;

	[FieldOffset(7344)]
	public long AtlasTreeContainerPtr;

	[FieldOffset(7360)]
	public byte NetworkState;

	[FieldOffset(7400)]
	public NativeStringU League;

	[FieldOffset(7520)]
	public int TimeInGame;

	[FieldOffset(7528)]
	public int TimeInGame2;

	[FieldOffset(7552)]
	public int Latency;

	[FieldOffset(7560)]
	public NativePtrArray PlayerStashTabs;

	[FieldOffset(7584)]
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

	[FieldOffset(7445)]
	public byte EaterOfWorldsCounter;

	[FieldOffset(7446)]
	public byte SearingExarchCounter;

	[FieldOffset(8192)]
	public long GuildName;

	[FieldOffset(8232)]
	public SkillBarIdsStruct SkillBarIds;

	[FieldOffset(8260)]
	public Vector2 WorldMousePosition;

	[FieldOffset(8280)]
	public long QuestFlagsPtr;

	[FieldOffset(8328)]
	public NativePtrArray NearestPlayers;

	[FieldOffset(7200)]
	public NativePtrArray EntityEffects;

	[FieldOffset(9072)]
	public NativePtrArray PlayerInventories;

	[FieldOffset(9768)]
	public NativePtrArray NPCInventories;

	[FieldOffset(10464)]
	public NativePtrArray GuildInventories;

	[FieldOffset(10824)]
	public ushort TradeChatChannel;

	[FieldOffset(10832)]
	public ushort GlobalChatChannel;

	[FieldOffset(10992)]
	public ushort LastActionId;

	[FieldOffset(9952)]
	public int CompletedMapsCount;

	[FieldOffset(10920)]
	public StdVector AncestorFightInfoList;

	[FieldOffset(11160)]
	public long CompletedMaps;

	[FieldOffset(11224)]
	public long BonusCompletedAreas;

	[FieldOffset(11848)]
	public int DialogDepth;

	[FieldOffset(11724)]
	public byte MonsterLevel;

	[FieldOffset(11853)]
	public byte MonstersRemaining;

	[FieldOffset(12034)]
	public int CurrentAzuriteAmount;

	[FieldOffset(12050)]
	public ushort CurrentSulphiteAmount;

	[FieldOffset(11296)]
	public NativePtrArray BlightLanes;

	[FieldOffset(12624)]
	public ServerDataArtifacts Artifacts;
}
