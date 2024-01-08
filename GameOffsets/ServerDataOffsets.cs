using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataOffsets
{
	public const int Skip = 32768;

	public const int ATLAS_REGION_UPGRADES = 34930;

	public const int WaypointsUnlockStateOffset = 43897;

	public const int BetrayalDataOffset2 = 1952;

	public const int AtlasPassivesListOffset = 352;

	public const int QuestFlagsOffset = 440;

	[FieldOffset(0)]
	public long MasterAreas;

	[FieldOffset(0)]
	public StdVector AncestorFightInfoList;

	[FieldOffset(7528)]
	public long PlayerRelatedData;

	[FieldOffset(7536)]
	public long AtlasTreeContainerPtr;

	[FieldOffset(7552)]
	public byte NetworkState;

	[FieldOffset(7592)]
	public NativeStringU League;

	[FieldOffset(7712)]
	public int TimeInGame;

	[FieldOffset(7720)]
	public int TimeInGame2;

	[FieldOffset(7744)]
	public int Latency;

	[FieldOffset(7752)]
	public NativePtrArray PlayerStashTabs;

	[FieldOffset(7776)]
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

	[FieldOffset(7637)]
	public byte EaterOfWorldsCounter;

	[FieldOffset(7638)]
	public byte SearingExarchCounter;

	[FieldOffset(8384)]
	public long GuildName;

	[FieldOffset(8448)]
	public SkillBarIdsStruct SkillBarIds;

	[FieldOffset(8476)]
	public Vector2 WorldMousePosition;

	[FieldOffset(8496)]
	public long QuestFlagsPtr;

	[FieldOffset(8544)]
	public NativePtrArray NearestPlayers;

	[FieldOffset(8592)]
	public StdVector MinimapIcons;

	[FieldOffset(7200)]
	public NativePtrArray EntityEffects;

	[FieldOffset(9296)]
	public NativePtrArray PlayerInventories;

	[FieldOffset(10000)]
	public NativePtrArray NPCInventories;

	[FieldOffset(10704)]
	public NativePtrArray GuildInventories;

	[FieldOffset(11064)]
	public ushort TradeChatChannel;

	[FieldOffset(11072)]
	public ushort GlobalChatChannel;

	[FieldOffset(11232)]
	public ushort LastActionId;

	[FieldOffset(9952)]
	public int CompletedMapsCount;

	[FieldOffset(11400)]
	public long CompletedMaps;

	[FieldOffset(11464)]
	public long BonusCompletedAreas;

	[FieldOffset(13000)]
	public int DialogDepth;

	[FieldOffset(13004)]
	public byte MonsterLevel;

	[FieldOffset(13005)]
	public byte MonstersRemaining;

	[FieldOffset(13186)]
	public int CurrentAzuriteAmount;

	[FieldOffset(13202)]
	public ushort CurrentSulphiteAmount;

	[FieldOffset(15344)]
	public ushort CurrentWildWisps;

	[FieldOffset(15346)]
	public ushort CurrentVividWisps;

	[FieldOffset(15348)]
	public ushort CurrentPrimalWisps;

	[FieldOffset(11296)]
	public NativePtrArray BlightLanes;

	[FieldOffset(13776)]
	public ServerDataArtifacts Artifacts;
}
