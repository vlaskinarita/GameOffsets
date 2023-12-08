using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RenderComponentOffsets
{
	[FieldOffset(168)]
	public Vector3 Pos;

	[FieldOffset(180)]
	public Vector3 Bounds;

	[FieldOffset(208)]
	public NativeStringU Name;

	[FieldOffset(240)]
	public Vector3 Rotation;

	[FieldOffset(268)]
	public float Height;
}
