using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IngameStateOffsets
{
	[FieldOffset(24)]
	public long Data;

	[FieldOffset(120)]
	public long WorldData;

	[FieldOffset(160)]
	public long EntityLabelMap;

	[FieldOffset(800)]
	public long UIRoot;

	[FieldOffset(856)]
	public long UIHoverElement;

	[FieldOffset(864)]
	public Vector2 CurentUIElementPos;

	[FieldOffset(872)]
	public long UIHover;

	[FieldOffset(912)]
	public Vector2i MouseGlobal;

	[FieldOffset(924)]
	public Vector2 UIHoverPos;

	[FieldOffset(932)]
	public Vector2 MouseInGame;

	[FieldOffset(1448)]
	public float TimeInGameF;

	[FieldOffset(1512)]
	public long IngameUi;
}
