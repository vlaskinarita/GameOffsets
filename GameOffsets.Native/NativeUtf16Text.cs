using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeUtf16Text
{
	public long Buffer;

	public long Reserved8Bytes;

	public long Length;

	public long LengthWithNullTerminator;

	public long ByteLength => Length * 2;

	public string CacheString => $"{Buffer}_{Reserved8Bytes}_{Length}";
}
