using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameUIElementsOffsets
{
	public const int CHAT_TITLE_OFFSET = 768;

	public const int CHAT_INPUT_OFFSET = 840;

	public const int CHAT_BOX_OFFSET_1 = 816;

	public const int CHAT_BOX_OFFSET_2 = 912;

	[FieldOffset(592)]	public long GetQuests;

	[FieldOffset(648)]	public long GameUI;

	[FieldOffset(984)]	public long Mouse;

	[FieldOffset(992)]	public long SkillBar;

	[FieldOffset(1000)]	public long HiddenSkillBar;

	[FieldOffset(1008)]	public long PartyElement;

	[FieldOffset(1080)]	public long BanditDialog;

	[FieldOffset(1160)]	public long ChatBox;

	[FieldOffset(1192)]	public long MapSideUI;

	[FieldOffset(1208)]	public long QuestTracker;

	[FieldOffset(1344)]	public long OpenLeftPanel;

	[FieldOffset(1352)]	public long InventoryPanel;

	[FieldOffset(1352)]	public long OpenRightPanel;

	[FieldOffset(1400)]	public long StashElement;

	[FieldOffset(1408)]	public long GuildStashElement;

	[FieldOffset(1416)]	public long SocialPanel;

	[FieldOffset(1464)]	public long UltimatumWorldPanel;

	[FieldOffset(1432)]	public long TreePanel;

	[FieldOffset(1448)]	public long AtlasPanel;

	[FieldOffset(1456)]	public long AtlasSkillPanel;

	[FieldOffset(1472)]	public long SettingsPanel;

	[FieldOffset(1480)]	public long ChallengePanel;

	[FieldOffset(1504)]	public long WorldMap;

	[FieldOffset(1528)]	public long HelpWindow;

	[FieldOffset(1568)]	public long Map;

	[FieldOffset(1576)]	public long itemsOnGroundLabelRoot;

	[FieldOffset(1720)]	public long NpcDialog;

	[FieldOffset(1728)]	public long ExpeditionNpcDialog;

	[FieldOffset(1744)]	public long QuestRewardWindow;

	[FieldOffset(1752)]	public long PurchaseWindow;

	[FieldOffset(1760)]	public long HaggleWindow;

	[FieldOffset(1760)]	public long PurchaseWindowHideout;

	[FieldOffset(1768)]	public long SellWindow;

	[FieldOffset(1776)]	public long SellWindowHideout;

	[FieldOffset(1784)]	public long TradeWindow;

	[FieldOffset(1792)]	public long MapReceptacleWindow;

	[FieldOffset(1800)]	public long LabyrinthDivineFontPanel;

	[FieldOffset(1864)]	public long TrialPlaquePanel;

	[FieldOffset(1872)]	public long AscendancySelectPanel;

	[FieldOffset(1824)]	public long MapDeviceWindow;

	[FieldOffset(1904)]	public long LabyrinthSelectPanel;

	[FieldOffset(1848)]	public long LabyrinthMapPanel;

	[FieldOffset(1896)]	public long CardTradeWindow;

	[FieldOffset(1904)]	public long IncursionWindow;

	[FieldOffset(1936)]	public long DelveWindow;

	[FieldOffset(1952)]	public long ZanaMissionChoice;

	[FieldOffset(1968)]	public long BetrayalWindow;

	[FieldOffset(1984)]	public long CraftBenchWindow;

	[FieldOffset(1992)]	public long UnveilWindow;

	[FieldOffset(2024)]	public long AnointingWindow;

	[FieldOffset(2048)]	public long HorticraftingStationWindow;

	[FieldOffset(2056)]	public long HeistWindow;

	[FieldOffset(2064)]	public long BlueprintWindow;

	[FieldOffset(2072)]	public long AllyEquipmentWindow;

	[FieldOffset(2080)]	public long GrandHeistWindow;

	[FieldOffset(2088)]	public long HeistLockerElement;

	[FieldOffset(2032)]	public long MetamorphWindow;

	[FieldOffset(1904)]	public long HeistContractWindow;

	[FieldOffset(1912)]	public long HeistRevealWindow;

	[FieldOffset(1920)]	public long HeistAllyEquipmentWindow;

	[FieldOffset(1928)]	public long HeistBlueprintWindow;

	[FieldOffset(1936)]	public long HeistLockerWindow;

	[FieldOffset(2096)]	public long RitualWindow;

	[FieldOffset(2192)]	public long UltimatumPanel;

	[FieldOffset(2192)]	public long UltimatumProgressWindow;

	[FieldOffset(2120)]	public long ExpeditionWindow;

	[FieldOffset(2128)]	public long ExpeditionWindowEmpty;

	[FieldOffset(2136)]	public long ExpeditionLockerElement;

	[FieldOffset(2168)]	public long SanctumFloorWindow;

	[FieldOffset(2224)]	public long AncestorFightSelectionWindow;

	[FieldOffset(2232)]	public long AncestorMainShopWindow;

	[FieldOffset(2344)]	public long CurrencyShiftClickMenu;

	[FieldOffset(2296)]	public long AreaInstanceUi;

	[FieldOffset(2376)]	public long DestroyConfirmationWindow;

	[FieldOffset(2352)]	public long PopUpWindow;

	[FieldOffset(2360)]	public long InstanceManagerPanel;

	[FieldOffset(2440)]	public long ResurrectPanel;

	[FieldOffset(2464)]	public long LeagueMechanicButtons;

	[FieldOffset(2520)]	public long ExpeditionDetonatorElement;

	[FieldOffset(2632)]	public long InvitesPanel;

	[FieldOffset(2656)]	public long GemLvlUpPanel;

	[FieldOffset(2752)]	public long BlightEncounterUi;

	[FieldOffset(2872)]	public long AncestorLeftShopPanel;

	[FieldOffset(2880)]	public long AncestorRightShopPanel;

	[FieldOffset(2912)]	public long ItemOnGroundTooltip;

	[FieldOffset(0)]	public long KalandraTabletWindow;

	[FieldOffset(0)]	public long SentinelWindow;

	[FieldOffset(0)]	public long MapTabWindowStartPtr;

	[FieldOffset(0)]	public long RitualFavourWindow;

	[FieldOffset(0)]	public long SynthesisWindow;
}
