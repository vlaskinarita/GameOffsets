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

	[FieldOffset(7704)]
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

	[FieldOffset(8312)]
	public NativeStringU PartyLeaderName;

	[FieldOffset(8328)]
	public byte PartyStatusType;

	[FieldOffset(8352)]
	public NativePtrArray CurrentParty;

	[FieldOffset(8376)]
	public byte PartyAllocationType;

	[FieldOffset(8377)]
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

	[FieldOffset(11200)]
	public ushort TradeChatChannel;

	[FieldOffset(11208)]
	public ushort GlobalChatChannel;

	[FieldOffset(11368)]
	public ushort LastActionId;

	[FieldOffset(10080)]
	public int CompletedMapsCount;

	[FieldOffset(11528)]
	public long CompletedMaps;

	[FieldOffset(11592)]
	public long BonusCompletedAreas;

	[FieldOffset(13144)]
	public int DialogDepth;

	[FieldOffset(13148)]
	public byte MonsterLevel;

	[FieldOffset(13149)]
	public byte MonstersRemaining;

	[FieldOffset(13330)]
	public int CurrentAzuriteAmount;

	[FieldOffset(13346)]
	public ushort CurrentSulphiteAmount;

	[FieldOffset(15488)]
	public ushort CurrentWildWisps;

	[FieldOffset(15490)]
	public ushort CurrentVividWisps;

	[FieldOffset(15492)]
	public ushort CurrentPrimalWisps;

	[FieldOffset(11440)]
	public NativePtrArray BlightLanes;

	[FieldOffset(13920)]
	public ServerDataArtifacts Artifacts;
}
