using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapSubElement
{
	public const int MapShift = 640;

	public const int MapShiftX = 640;

	public const int MapShiftY = 644;

	public const int DefaultMapShift = 648;

	public const int MapZoom = 708;
}
