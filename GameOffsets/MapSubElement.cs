using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapSubElement
{
	public const int MapShift = 616;

	public const int MapShiftX = 616;

	public const int MapShiftY = 620;

	public const int DefaultMapShift = 624;

	public const int MapZoom = 684;
}
