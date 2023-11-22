using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CameraOffsets
{
	[FieldOffset(664)]
	public int Width;

	[FieldOffset(668)]
	public int Height;

	[FieldOffset(320)]
	public Matrix4x4 MatrixBytes;

	[FieldOffset(436)]
	public Vector3 Position;

	[FieldOffset(596)]
	public float ZFar;
}
