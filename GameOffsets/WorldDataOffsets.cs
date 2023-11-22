using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldDataOffsets
{
	[FieldOffset(168)]
	public CameraOffsets Camera;
}
