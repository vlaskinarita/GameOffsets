using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit)]
public struct DatArrayStruct
{
	[FieldOffset(0)]
	public int Count;

	[FieldOffset(8)]
	public long ItemArrayPtr;
}
