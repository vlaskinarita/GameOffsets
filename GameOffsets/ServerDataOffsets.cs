using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataOffsets
{
	public const int Skip = 32768;

	public const int ATLAS_REGION_UPGRADES = 34930;

	public const int WaypointsUnlockStateOffset = 44025;

	public const int BetrayalDataOffset2 = 1952;

	public const int AtlasPassivesListOffset = 352;

	public const int QuestFlagsOffset = 440;

	[FieldOffset(0)]
	public long MasterAreas;

	[FieldOffset(0)]
	public StdVector AncestorFightInfoList;

	[FieldOffset(7656)]
	public long PlayerRelatedData;

	[FieldOffset(7664)]
	public long AtlasTreeContainerPtr;

	[FieldOffset(7680)]
	public byte NetworkState;

	[FieldOffset(7720)]
	public NativeStringU League;

	[FieldOffset(7840)]
	public int TimeInGame;

	[FieldOffset(7848)]
	public int TimeInGame2;

	[FieldOffset(7872)]
	public int Latency;

	[FieldOffset(7880)]
	public NativePtrArray PlayerStashTabs;

	[FieldOffset(7904)]
	public NativePtrArray GuildStashTabs;

	[FieldOffset(5944)]
	public NativeStringU PartyLeaderName;

	[FieldOffset(5960)]
	public byte PartyStatusType;

	[FieldOffset(5984)]
	public NativePtrArray CurrentParty;

	[FieldOffset(6008)]
	public byte PartyAllocationType;

	[FieldOffset(6009)]
	public bool PartyDownscaleDisabled;

	[FieldOffset(7765)]
	public byte EaterOfWorldsCounter;

	[FieldOffset(7766)]
	public byte SearingExarchCounter;

	[FieldOffset(8512)]
	public long GuildName;

	[FieldOffset(8576)]
	public SkillBarIdsStruct SkillBarIds;

	[FieldOffset(8604)]
	public Vector2 WorldMousePosition;

	[FieldOffset(8624)]
	public long QuestFlagsPtr;

	[FieldOffset(8672)]
	public NativePtrArray NearestPlayers;

	[FieldOffset(8720)]
	public StdVector MinimapIcons;

	[FieldOffset(7328)]
	public NativePtrArray EntityEffects;

	[FieldOffset(9424)]
	public NativePtrArray PlayerInventories;

	[FieldOffset(10128)]
	public NativePtrArray NPCInventories;

	[FieldOffset(10832)]
	public NativePtrArray GuildInventories;

	[FieldOffset(11192)]
	public ushort TradeChatChannel;

	[FieldOffset(11200)]
	public ushort GlobalChatChannel;

	[FieldOffset(11360)]
	public ushort LastActionId;

	[FieldOffset(10080)]
	public int CompletedMapsCount;

	[FieldOffset(11528)]
	public long CompletedMaps;

	[FieldOffset(11592)]
	public long BonusCompletedAreas;

	[FieldOffset(13128)]
	public int DialogDepth;

	[FieldOffset(13132)]
	public byte MonsterLevel;

	[FieldOffset(13133)]
	public byte MonstersRemaining;

	[FieldOffset(13314)]
	public int CurrentAzuriteAmount;

	[FieldOffset(13330)]
	public ushort CurrentSulphiteAmount;

	[FieldOffset(15472)]
	public ushort CurrentWildWisps;

	[FieldOffset(15474)]
	public ushort CurrentVividWisps;

	[FieldOffset(15476)]
	public ushort CurrentPrimalWisps;

	[FieldOffset(11424)]
	public NativePtrArray BlightLanes;

	[FieldOffset(13904)]
	public ServerDataArtifacts Artifacts;
}
