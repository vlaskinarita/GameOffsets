using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CameraOffsets
{
	[FieldOffset(308)]
	public Vector3 Position;

	[FieldOffset(320)]
	public Matrix4x4 MatrixBytes;

	[FieldOffset(532)]
	public float ZFar;

	[FieldOffset(600)]
	public int Width;

	[FieldOffset(604)]
	public int Height;
}
