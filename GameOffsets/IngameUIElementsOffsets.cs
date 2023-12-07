using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameUIElementsOffsets
{
	public const int CHAT_TITLE_OFFSET = 768;

	public const int CHAT_INPUT_OFFSET = 840;

	public const int CHAT_BOX_OFFSET_1 = 816;

	public const int CHAT_BOX_OFFSET_2 = 920;

	[FieldOffset(560)]
	public long GetQuests;

	[FieldOffset(616)]
	public long GameUI;

	[FieldOffset(952)]
	public long Mouse;

	[FieldOffset(960)]
	public long SkillBar;

	[FieldOffset(960)]
	public long HiddenSkillBar;

	[FieldOffset(976)]
	public long PartyElement;

	[FieldOffset(1080)]
	public long BanditDialog;

	[FieldOffset(1128)]
	public long ChatBox;

	[FieldOffset(1160)]
	public long MapSideUI;

	[FieldOffset(1176)]
	public long QuestTracker;

	[FieldOffset(1312)]
	public long OpenLeftPanel;

	[FieldOffset(1320)]
	public long InventoryPanel;

	[FieldOffset(1320)]
	public long OpenRightPanel;

	[FieldOffset(1368)]
	public long StashElement;

	[FieldOffset(1376)]
	public long GuildStashElement;

	[FieldOffset(1392)]
	public long SocialPanel;

	[FieldOffset(1432)]
	public long UltimatumWorldPanel;

	[FieldOffset(1400)]
	public long TreePanel;

	[FieldOffset(1416)]
	public long AtlasPanel;

	[FieldOffset(1424)]
	public long AtlasSkillPanel;

	[FieldOffset(1440)]
	public long SettingsPanel;

	[FieldOffset(1448)]
	public long ChallengePanel;

	[FieldOffset(1472)]
	public long WorldMap;

	[FieldOffset(1496)]
	public long HelpWindow;

	[FieldOffset(1544)]
	public long Map;

	[FieldOffset(1552)]
	public long itemsOnGroundLabelRoot;

	[FieldOffset(1696)]
	public long NpcDialog;

	[FieldOffset(1704)]
	public long ExpeditionNpcDialog;

	[FieldOffset(1720)]
	public long QuestRewardWindow;

	[FieldOffset(1728)]
	public long PurchaseWindow;

	[FieldOffset(1736)]
	public long HaggleWindow;

	[FieldOffset(1736)]
	public long PurchaseWindowHideout;

	[FieldOffset(1744)]
	public long SellWindow;

	[FieldOffset(1752)]
	public long SellWindowHideout;

	[FieldOffset(1760)]
	public long TradeWindow;

	[FieldOffset(1768)]
	public long MapReceptacleWindow;

	[FieldOffset(1776)]
	public long LabyrinthDivineFontPanel;

	[FieldOffset(1784)]
	public long TrialPlaquePanel;

	[FieldOffset(1792)]
	public long AscendancySelectPanel;

	[FieldOffset(1800)]
	public long MapDeviceWindow;

	[FieldOffset(1816)]
	public long LabyrinthSelectPanel;

	[FieldOffset(1824)]
	public long LabyrinthMapPanel;

	[FieldOffset(1872)]
	public long CardTradeWindow;

	[FieldOffset(1880)]
	public long IncursionWindow;

	[FieldOffset(1912)]
	public long DelveWindow;

	[FieldOffset(1928)]
	public long ZanaMissionChoice;

	[FieldOffset(1944)]
	public long BetrayalWindow;

	[FieldOffset(1960)]
	public long CraftBenchWindow;

	[FieldOffset(1968)]
	public long UnveilWindow;

	[FieldOffset(2000)]
	public long AnointingWindow;

	[FieldOffset(2024)]
	public long HorticraftingStationWindow;

	[FieldOffset(2032)]
	public long HeistWindow;

	[FieldOffset(2040)]
	public long BlueprintWindow;

	[FieldOffset(2048)]
	public long AllyEquipmentWindow;

	[FieldOffset(2056)]
	public long GrandHeistWindow;

	[FieldOffset(2064)]
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

	[FieldOffset(2072)]
	public long RitualWindow;

	[FieldOffset(2192)]
	public long UltimatumPanel;

	[FieldOffset(2192)]
	public long UltimatumProgressWindow;

	[FieldOffset(2120)]
	public long ExpeditionWindow;

	[FieldOffset(2128)]
	public long ExpeditionWindowEmpty;

	[FieldOffset(2136)]
	public long ExpeditionLockerElement;

	[FieldOffset(2160)]
	public long SanctumFloorWindow;

	[FieldOffset(2176)]
	public long SanctumRewardWindow;

	[FieldOffset(2216)]
	public long AncestorFightSelectionWindow;

	[FieldOffset(2224)]
	public long AncestorMainShopWindow;

	[FieldOffset(2336)]
	public long CurrencyShiftClickMenu;

	[FieldOffset(2288)]
	public long AreaInstanceUi;

	[FieldOffset(2368)]
	public long DestroyConfirmationWindow;

	[FieldOffset(2344)]
	public long PopUpWindow;

	[FieldOffset(2352)]
	public long InstanceManagerPanel;

	[FieldOffset(2432)]
	public long ResurrectPanel;

	[FieldOffset(2456)]
	public long LeagueMechanicButtons;

	[FieldOffset(2512)]
	public long ExpeditionDetonatorElement;

	[FieldOffset(2624)]
	public long InvitesPanel;

	[FieldOffset(2648)]
	public long GemLvlUpPanel;

	[FieldOffset(2744)]
	public long BlightEncounterUi;

	[FieldOffset(2864)]
	public long AncestorLeftShopPanel;

	[FieldOffset(2872)]
	public long AncestorRightShopPanel;

	[FieldOffset(2920)]
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
