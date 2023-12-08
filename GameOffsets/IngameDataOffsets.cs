using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameDataOffsets
{
	[FieldOffset(80)]
	public long LabDataPtr;

	[FieldOffset(176)]
	public long CurrentArea;

	[FieldOffset(212)]
	public byte CurrentAreaLevel;

	[FieldOffset(276)]
	public uint CurrentAreaHash;

	[FieldOffset(296)]
	public NativePtrArray MapStats;

	[FieldOffset(656)]
	public long IngameStatePtr;

	[FieldOffset(848)]
	public long IngameStatePtr2;

	[FieldOffset(2112)]
	public StdVector EffectEnvironments;

	[FieldOffset(2160)]
	public long ServerData;

	[FieldOffset(2168)]
	public long LocalPlayer;

	[FieldOffset(2344)]
	public long EntityList;

	[FieldOffset(2352)]
	public long EntitiesCount;

	[FieldOffset(2768)]
	public TerrainData Terrain;

	[FieldOffset(2632)]
	public NativePtrArray TgtArray;

	[FieldOffset(2704)]
	public int MillisecondsSpentInMapBeforeZoneIn;

	[FieldOffset(2712)]
	public long ZoneInQPC;

	[FieldOffset(3688)]
	public long EnvironmentDataPtr;
}
