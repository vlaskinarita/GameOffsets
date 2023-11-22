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

	[FieldOffset(672)]
	public long UIRoot;

	[FieldOffset(728)]
	public long UIHoverElement;

	[FieldOffset(736)]
	public Vector2 CurentUIElementPos;

	[FieldOffset(744)]
	public long UIHover;

	[FieldOffset(784)]
	public Vector2i MouseGlobal;

	[FieldOffset(796)]
	public Vector2 UIHoverPos;

	[FieldOffset(804)]
	public Vector2 MouseInGame;

	[FieldOffset(1320)]
	public float TimeInGameF;

	[FieldOffset(1384)]
	public long IngameUi;
}
