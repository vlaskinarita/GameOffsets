using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UnorderedMapBucket
{
	[FieldOffset(0)]
	public long LastNodePtr;

	[FieldOffset(8)]
	public long FirstNodePtr;
}
