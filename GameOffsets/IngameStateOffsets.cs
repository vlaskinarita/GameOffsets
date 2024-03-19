using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameStateOffsets
{
	[FieldOffset(536)]
	public long Data;

	[FieldOffset(632)]
	public long WorldData;

	[FieldOffset(672)]
	public long EntityLabelMap;

	[FieldOffset(1312)]
	public long UIRoot;

	[FieldOffset(1368)]
	public long UIHoverElement;

	[FieldOffset(1376)]
	public Vector2 CurentUIElementPos;

	[FieldOffset(1384)]
	public long UIHover;

	[FieldOffset(1424)]
	public Vector2i MouseGlobal;

	[FieldOffset(1436)]
	public Vector2 UIHoverPos;

	[FieldOffset(1444)]
	public Vector2 MouseInGame;

	[FieldOffset(1960)]
	public float TimeInGameF;

	[FieldOffset(2024)]
	public long IngameUi;
}
