using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapComponentInner
{
	[FieldOffset(32)]
	public long Area;

	[FieldOffset(88)]
	public int MapSeries;
}
