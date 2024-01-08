using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UnorderedMap
{
	[FieldOffset(8)]
	public long InvalidBucketPtr;

	[FieldOffset(24)]
	public StdVector Buckets;

	[FieldOffset(48)]
	public ulong BucketIndexMask;
}
