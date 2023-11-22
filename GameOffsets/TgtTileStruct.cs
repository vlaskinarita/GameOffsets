using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TgtTileStruct
{
	[FieldOffset(8)]
	public NativeStringU TgtPath;

	[FieldOffset(48)]
	public long TgtDetailPtr;
}
