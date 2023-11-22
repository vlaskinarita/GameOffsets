using System;
using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
[Obsolete("This will be removed (Reason: bad name)")]
public struct NativeStringU
{
	[FieldOffset(0)]
	public long buf;

	[FieldOffset(8)]
	public long buf2;

	[FieldOffset(16)]
	public uint Size;

	[FieldOffset(24)]
	public uint Capacity;

	public static implicit operator NativeUtf16Text(NativeStringU s)
	{
		NativeUtf16Text result = default(NativeUtf16Text);
		result.Buffer = s.buf;
		result.Reserved8Bytes = s.buf2;
		result.Length = s.Size;
		result.LengthWithNullTerminator = s.Capacity;
		return result;
	}
}
