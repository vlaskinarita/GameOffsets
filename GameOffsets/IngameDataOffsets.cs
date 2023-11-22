using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameDataOffsets
{
	[FieldOffset(136)]
	public long CurrentArea;

	[FieldOffset(168)]
	public byte CurrentAreaLevel;

	[FieldOffset(236)]
	public uint CurrentAreaHash;

	[FieldOffset(256)]
	public NativePtrArray MapStats;

	[FieldOffset(280)]
	public long LabDataPtr;

	[FieldOffset(656)]
	public long IngameStatePtr;

	[FieldOffset(848)]
	public long IngameStatePtr2;

	[FieldOffset(2128)]
	public long ServerData;

	[FieldOffset(2136)]
	public long LocalPlayer;

	[FieldOffset(2312)]
	public long EntityList;

	[FieldOffset(2320)]
	public long EntitiesCount;

	[FieldOffset(2728)]
	public TerrainData Terrain;

	[FieldOffset(2632)]
	public NativePtrArray TgtArray;
}
