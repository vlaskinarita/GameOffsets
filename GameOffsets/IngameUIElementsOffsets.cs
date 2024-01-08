using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameUIElementsOffsets
{
	public const int CHAT_TITLE_OFFSET = 784;

	public const int CHAT_INPUT_OFFSET = 856;

	public const int CHAT_BOX_OFFSET_1 = 832;

	public const int CHAT_BOX_OFFSET_2 = 936;

	[FieldOffset(576)]
	public long GetQuests;

	[FieldOffset(632)]
	public long GameUI;

	[FieldOffset(968)]
	public long Mouse;

	[FieldOffset(976)]
	public long SkillBar;

	[FieldOffset(960)]
	public long HiddenSkillBar;

	[FieldOffset(992)]
	public long PartyElement;

	[FieldOffset(1064)]
	public long BanditDialog;

	[FieldOffset(1144)]
	public long ChatBox;

	[FieldOffset(1176)]
	public long MapSideUI;

	[FieldOffset(1176)]
	public long QuestTracker;

	[FieldOffset(1328)]
	public long OpenLeftPanel;

	[FieldOffset(1336)]
	public long InventoryPanel;

	[FieldOffset(1336)]
	public long OpenRightPanel;

	[FieldOffset(1384)]
	public long StashElement;

	[FieldOffset(1376)]
	public long GuildStashElement;

	[FieldOffset(1408)]
	public long SocialPanel;

	[FieldOffset(1432)]
	public long UltimatumWorldPanel;

	[FieldOffset(1416)]
	public long TreePanel;

	[FieldOffset(1432)]
	public long AtlasPanel;

	[FieldOffset(1440)]
	public long AtlasSkillPanel;

	[FieldOffset(1456)]
	public long SettingsPanel;

	[FieldOffset(1464)]
	public long ChallengePanel;

	[FieldOffset(1488)]
	public long WorldMap;

	[FieldOffset(1512)]
	public long HelpWindow;

	[FieldOffset(1560)]
	public long Map;

	[FieldOffset(1568)]
	public long itemsOnGroundLabelRoot;

	[FieldOffset(1704)]
	public long NpcDialog;

	[FieldOffset(1712)]
	public long ExpeditionNpcDialog;

	[FieldOffset(1728)]
	public long QuestRewardWindow;

	[FieldOffset(1736)]
	public long PurchaseWindow;

	[FieldOffset(1744)]
	public long HaggleWindow;

	[FieldOffset(1744)]
	public long PurchaseWindowHideout;

	[FieldOffset(1752)]
	public long SellWindow;

	[FieldOffset(1760)]
	public long SellWindowHideout;

	[FieldOffset(1768)]
	public long TradeWindow;

	[FieldOffset(1776)]
	public long MapReceptacleWindow;

	[FieldOffset(1784)]
	public long LabyrinthDivineFontPanel;

	[FieldOffset(1792)]
	public long TrialPlaquePanel;

	[FieldOffset(1792)]
	public long AscendancySelectPanel;

	[FieldOffset(1808)]
	public long MapDeviceWindow;

	[FieldOffset(1824)]
	public long LabyrinthSelectPanel;

	[FieldOffset(1832)]
	public long LabyrinthMapPanel;

	[FieldOffset(1880)]
	public long CardTradeWindow;

	[FieldOffset(1888)]
	public long IncursionWindow;

	[FieldOffset(1920)]
	public long DelveWindow;

	[FieldOffset(1936)]
	public long ZanaMissionChoice;

	[FieldOffset(1952)]
	public long BetrayalWindow;

	[FieldOffset(1968)]
	public long CraftBenchWindow;

	[FieldOffset(1976)]
	public long UnveilWindow;

	[FieldOffset(2008)]
	public long AnointingWindow;

	[FieldOffset(2016)]
	public long HorticraftingStationWindow;

	[FieldOffset(2024)]
	public long HeistWindow;

	[FieldOffset(2032)]
	public long BlueprintWindow;

	[FieldOffset(2040)]
	public long AllyEquipmentWindow;

	[FieldOffset(2048)]
	public long GrandHeistWindow;

	[FieldOffset(2056)]
	public long HeistLockerElement;

	[FieldOffset(2008)]
	public long MetamorphWindow;

	[FieldOffset(1880)]
	public long HeistContractWindow;

	[FieldOffset(1888)]
	public long HeistRevealWindow;

	[FieldOffset(1896)]
	public long HeistAllyEquipmentWindow;

	[FieldOffset(1904)]
	public long HeistBlueprintWindow;

	[FieldOffset(1912)]
	public long HeistLockerWindow;

	[FieldOffset(2064)]
	public long RitualWindow;

	[FieldOffset(2080)]
	public long UltimatumPanel;

	[FieldOffset(2088)]
	public long ExpeditionWindow;

	[FieldOffset(2096)]
	public long ExpeditionWindowEmpty;

	[FieldOffset(2136)]
	public long ExpeditionLockerElement;

	[FieldOffset(2152)]
	public long SanctumFloorWindow;

	[FieldOffset(2168)]
	public long SanctumRewardWindow;

	[FieldOffset(2208)]
	public long AncestorFightSelectionWindow;

	[FieldOffset(2216)]
	public long AncestorMainShopWindow;

	[FieldOffset(2328)]
	public long CurrencyShiftClickMenu;

	[FieldOffset(2288)]
	public long AreaInstanceUi;

	[FieldOffset(2360)]
	public long DestroyConfirmationWindow;

	[FieldOffset(2336)]
	public long PopUpWindow;

	[FieldOffset(2344)]
	public long InstanceManagerPanel;

	[FieldOffset(2424)]
	public long ResurrectPanel;

	[FieldOffset(2448)]
	public long LeagueMechanicButtons;

	[FieldOffset(2496)]
	public long ExpeditionDetonatorElement;

	[FieldOffset(2624)]
	public long InvitesPanel;

	[FieldOffset(2632)]
	public long GemLvlUpPanel;

	[FieldOffset(2752)]
	public long BlightEncounterUi;

	[FieldOffset(2848)]
	public long AncestorLeftShopPanel;

	[FieldOffset(2856)]
	public long AncestorRightShopPanel;

	[FieldOffset(2912)]
	public long ItemOnGroundTooltip;

	[FieldOffset(2144)]
	public long KalandraTabletWindow;

	[FieldOffset(1504)]
	public long SentinelWindow;

	[FieldOffset(0)]
	public long MapTabWindowStartPtr;

	[FieldOffset(0)]
	public long RitualFavourWindow;

	[FieldOffset(0)]
	public long SynthesisWindow;
}
