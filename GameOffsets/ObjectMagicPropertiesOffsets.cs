using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ObjectMagicPropertiesOffsets
{
	[FieldOffset(324)]
	public int Rarity;

	[FieldOffset(360)]
	public NativePtrArray Mods;
}
