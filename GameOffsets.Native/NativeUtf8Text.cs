using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NativeUtf8Text
{
	[FieldOffset(0)]
	public long Buffer;

	[FieldOffset(8)]
	public long Reserved8Bytes;

	[FieldOffset(16)]
	public int Length;

	[FieldOffset(24)]
	public int LengthWithNullTerminator;

	public string CacheString => $"{Buffer:X16}_{Reserved8Bytes:X16}_{Length}";
}
