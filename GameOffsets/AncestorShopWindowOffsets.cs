using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestorShopWindowOffsets
{
	[FieldOffset(552)]
	public long UnitPtr;

	[FieldOffset(568)]
	public long ItemPtr;
}
