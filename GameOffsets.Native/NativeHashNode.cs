using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NativeHashNode
{
	[FieldOffset(0)]
	public readonly long Previous;

	[FieldOffset(8)]
	public readonly long Root;

	[FieldOffset(16)]
	public readonly long Next;

	[FieldOffset(25)]
	public readonly byte IsNull;

	[FieldOffset(32)]
	public int Key;

	[FieldOffset(40)]
	public long Value1;

	public override string ToString()
	{
		return "NativeHashNode";
	}
}
