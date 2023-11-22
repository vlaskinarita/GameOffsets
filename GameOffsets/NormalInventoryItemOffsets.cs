using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NormalInventoryItemOffsets
{
	[FieldOffset(880)]
	public long Item;

	[FieldOffset(980)]
	public int Width;

	[FieldOffset(984)]
	public int Height;
}
