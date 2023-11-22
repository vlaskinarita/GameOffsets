using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameDataOffsets
{
	[FieldOffset(80)]
	public long LabDataPtr;

	[FieldOffset(136)]
	public long CurrentArea;

	[FieldOffset(172)]
	public byte CurrentAreaLevel;

	[FieldOffset(236)]
	public uint CurrentAreaHash;

	[FieldOffset(256)]
	public NativePtrArray MapStats;

	[FieldOffset(656)]
	public long IngameStatePtr;

	[FieldOffset(848)]
	public long IngameStatePtr2;

	[FieldOffset(2072)]
	public StdVector EffectEnvironments;

	[FieldOffset(2120)]
	public long ServerData;

	[FieldOffset(2128)]
	public long LocalPlayer;

	[FieldOffset(2304)]
	public long EntityList;

	[FieldOffset(2312)]
	public long EntitiesCount;

	[FieldOffset(2720)]
	public TerrainData Terrain;

	[FieldOffset(2632)]
	public NativePtrArray TgtArray;

	[FieldOffset(3616)]
	public long EnvironmentDataPtr;
}
