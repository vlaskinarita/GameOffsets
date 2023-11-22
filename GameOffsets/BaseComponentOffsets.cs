using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BaseComponentOffsets
{
	[FieldOffset(16)]
	public long ItemInfo;

	[FieldOffset(198)]
	public byte Influence;

	[FieldOffset(199)]
	public byte Corrupted;

	[FieldOffset(96)]
	public NativeStringU PublicPrice;

	[FieldOffset(200)]
	public int UnspentAbsorbedCorruption;

	[FieldOffset(204)]
	public int ScourgedTier;
}
