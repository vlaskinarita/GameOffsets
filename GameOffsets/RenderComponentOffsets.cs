using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RenderComponentOffsets
{
	[FieldOffset(160)]
	public Vector3 Pos;

	[FieldOffset(172)]
	public Vector3 Bounds;

	[FieldOffset(200)]
	public NativeStringU Name;

	[FieldOffset(232)]
	public Vector3 Rotation;

	[FieldOffset(260)]
	public float Height;
}
