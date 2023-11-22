using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataOffsets
{
	public const int Skip = 32768;

	public const int ATLAS_REGION_UPGRADES = 34930;

	public const int WaypointsUnlockStateOffset = 43265;

	public const int BetrayalDataOffset2 = 1968;

	public const int AtlasPassivesListOffset = 352;

	[FieldOffset(0)]
	public long MasterAreas;

	[FieldOffset(6944)]
	public long PlayerRelatedData;

	[FieldOffset(6952)]
	public long AtlasTreeContainerPtr;

	[FieldOffset(6968)]
	public byte NetworkState;

	[FieldOffset(7008)]
	public NativeStringU League;

	[FieldOffset(7128)]
	public int TimeInGame;

	[FieldOffset(7136)]
	public int TimeInGame2;

	[FieldOffset(7160)]
	public int Latency;

	[FieldOffset(7168)]
	public NativePtrArray PlayerStashTabs;

	[FieldOffset(7192)]
	public NativePtrArray GuildStashTabs;

	[FieldOffset(5552)]
	public NativeStringU PartyLeaderName;

	[FieldOffset(5568)]
	public byte PartyStatusType;

	[FieldOffset(5592)]
	public NativePtrArray CurrentParty;

	[FieldOffset(5616)]
	public byte PartyAllocationType;

	[FieldOffset(5617)]
	public bool PartyDownscaleDisabled;

	[FieldOffset(7800)]
	public long GuildName;

	[FieldOffset(7840)]
	public SkillBarIdsStruct SkillBarIds;

	[FieldOffset(7868)]
	public Vector2 WorldMousePosition;

	[FieldOffset(7936)]
	public NativePtrArray NearestPlayers;

	[FieldOffset(6936)]
	public NativePtrArray EntityEffects;

	[FieldOffset(8680)]
	public NativePtrArray PlayerInventories;

	[FieldOffset(9376)]
	public NativePtrArray NPCInventories;

	[FieldOffset(10072)]
	public NativePtrArray GuildInventories;

	[FieldOffset(10432)]
	public ushort TradeChatChannel;

	[FieldOffset(10440)]
	public ushort GlobalChatChannel;

	[FieldOffset(10600)]
	public ushort LastActionId;

	[FieldOffset(9688)]
	public int CompletedMapsCount;

	[FieldOffset(10656)]
	public StdVector AncestorFightInfoList;

	[FieldOffset(10768)]
	public long CompletedMaps;

	[FieldOffset(10832)]
	public long BonusCompletedAreas;

	[FieldOffset(11456)]
	public int DialogDepth;

	[FieldOffset(11460)]
	public byte MonsterLevel;

	[FieldOffset(11461)]
	public byte MonstersRemaining;

	[FieldOffset(11642)]
	public int CurrentAzuriteAmount;

	[FieldOffset(11658)]
	public ushort CurrentSulphiteAmount;

	[FieldOffset(11032)]
	public NativePtrArray BlightLanes;

	[FieldOffset(12232)]
	public ServerDataArtifacts Artifacts;
}
