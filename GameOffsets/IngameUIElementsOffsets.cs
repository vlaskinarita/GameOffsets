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

	[FieldOffset(960)]
	public long Mouse;

	[FieldOffset(968)]
	public long SkillBar;

	[FieldOffset(968)]
	public long HiddenSkillBar;

	[FieldOffset(984)]
	public long PartyElement;

	[FieldOffset(1056)]
	public long BanditDialog;

	[FieldOffset(1136)]
	public long ChatBox;

	[FieldOffset(1168)]
	public long MapSideUI;

	[FieldOffset(1168)]
	public long QuestTracker;

	[FieldOffset(1320)]
	public long OpenLeftPanel;

	[FieldOffset(1328)]
	public long OpenRightPanel;

	[FieldOffset(1368)]
	public long InventoryPanel;

	[FieldOffset(1376)]
	public long StashElement;

	[FieldOffset(1384)]
	public long GuildStashElement;

	[FieldOffset(1400)]
	public long SocialPanel;

	[FieldOffset(1424)]
	public long UltimatumWorldPanel;

	[FieldOffset(1408)]
	public long TreePanel;

	[FieldOffset(1424)]
	public long AtlasPanel;

	[FieldOffset(1432)]
	public long AtlasSkillPanel;

	[FieldOffset(1448)]
	public long SettingsPanel;

	[FieldOffset(1456)]
	public long ChallengePanel;

	[FieldOffset(1480)]
	public long WorldMap;

	[FieldOffset(1504)]
	public long HelpWindow;

	[FieldOffset(1552)]
	public long Map;

	[FieldOffset(1560)]
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
	public long LabyrinthDivineFontPanel;

	[FieldOffset(1776)]
	public long TrialPlaquePanel;

	[FieldOffset(1784)]
	public long AscendancySelectPanel;

	[FieldOffset(1800)]
	public long MapReceptacleWindow;

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

	[FieldOffset(2008)]
	public long HorticraftingStationWindow;

	[FieldOffset(2016)]
	public long HeistWindow;

	[FieldOffset(2024)]
	public long BlueprintWindow;

	[FieldOffset(2032)]
	public long AllyEquipmentWindow;

	[FieldOffset(2040)]
	public long GrandHeistWindow;

	[FieldOffset(2048)]
	public long HeistLockerElement;

	[FieldOffset(2008)]
	public long MetamorphWindow;

	[FieldOffset(2016)]
	public long HeistContractWindow;

	[FieldOffset(2024)]
	public long HeistRevealWindow;

	[FieldOffset(2032)]
	public long HeistAllyEquipmentWindow;

	[FieldOffset(2040)]
	public long HeistBlueprintWindow;

	[FieldOffset(2048)]
	public long HeistLockerWindow;

	[FieldOffset(2056)]
	public long RitualWindow;

	[FieldOffset(2072)]
	public long UltimatumPanel;

	[FieldOffset(2080)]
	public long ExpeditionWindow;

	[FieldOffset(2088)]
	public long ExpeditionWindowEmpty;

	[FieldOffset(2128)]
	public long ExpeditionLockerElement;

	[FieldOffset(2144)]
	public long SanctumFloorWindow;

	[FieldOffset(2160)]
	public long SanctumRewardWindow;

	[FieldOffset(2200)]
	public long AncestorFightSelectionWindow;

	[FieldOffset(2208)]
	public long AncestorMainShopWindow;

	[FieldOffset(2320)]
	public long CurrencyShiftClickMenu;

	[FieldOffset(2328)]
	public long DestroyConfirmationWindow;

	[FieldOffset(2328)]
	public long PopUpWindow;

	[FieldOffset(2336)]
	public long AreaInstanceUi;

	[FieldOffset(2336)]
	public long InstanceManagerPanel;

	[FieldOffset(2416)]
	public long ResurrectPanel;

	[FieldOffset(2440)]
	public long LeagueMechanicButtons;

	[FieldOffset(2488)]
	public long ExpeditionDetonatorElement;

	[FieldOffset(2616)]
	public long InvitesPanel;

	[FieldOffset(2552)]
	public long GemLvlUpPanel;

	[FieldOffset(2752)]
	public long BlightEncounterUi;

	[FieldOffset(2848)]
	public long AncestorLeftShopPanel;

	[FieldOffset(2856)]
	public long AncestorRightShopPanel;

	[FieldOffset(2904)]
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
