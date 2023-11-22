using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit)]
public struct ExpeditionDetonatorInfoOffsets
{
	public const int ExpeditionDetonatorInfoOffset = 632;

	[FieldOffset(432)]
	public long PlacementMarkerPtr;

	[FieldOffset(488)]
	public StdVector PlacedExplosives;

	[FieldOffset(680)]
	public Vector2i DetonatorGridPosition;

	[FieldOffset(696)]
	public Vector2i PlacementIndicatorGridPosition;

	[FieldOffset(720)]
	public byte TotalExplosiveCount;
}
