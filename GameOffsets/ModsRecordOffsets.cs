using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModsRecordOffsets
{
	[FieldOffset(0)]
	public NativeStringU Key;

	[FieldOffset(8)]
	public int Hash;

	[FieldOffset(12)]
	public long TypePtr;

	[FieldOffset(28)]
	public int MinLevel;

	[FieldOffset(32)]
	public long Stat1Ptr;

	[FieldOffset(48)]
	public long Stat2Ptr;

	[FieldOffset(64)]
	public long Stat3Ptr;

	[FieldOffset(80)]
	public long Stat4Ptr;

	[FieldOffset(96)]
	public int Domain;

	[FieldOffset(100)]
	public long UserFriendlyName;

	[FieldOffset(108)]
	public int AffixType;

	[FieldOffset(112)]
	public (long Count, long Ptr) Group;

	[FieldOffset(120)]
	public long Something;

	[FieldOffset(128)]
	public Vector2i Stat1Range;

	[FieldOffset(136)]
	public Vector2i Stat2Range;

	[FieldOffset(144)]
	public Vector2i Stat3Range;

	[FieldOffset(152)]
	public Vector2i Stat4Range;

	[FieldOffset(160)]
	public long Tags;

	[FieldOffset(168)]
	public long ta;

	[FieldOffset(176)]
	public int TagChances;

	[FieldOffset(184)]
	public long tc;

	[FieldOffset(192)]
	public long BuffDefinitionsPtr;

	[FieldOffset(200)]
	public long BuffDefinitions;

	[FieldOffset(208)]
	public int BuffValue;

	[FieldOffset(212)]
	public long tgcCount;

	[FieldOffset(204)]
	public long tgcPtr;

	[FieldOffset(280)]
	public Vector2i Stat5Range;

	[FieldOffset(288)]
	public long Stat5Ptr;

	[FieldOffset(385)]
	public Vector2i Stat6Range;

	[FieldOffset(393)]
	public long Stat6Ptr;

	[FieldOffset(436)]
	public byte IsEssence;

	[FieldOffset(461)]
	public long Tier;
}
