using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NativeListNodeComponent
{
	[FieldOffset(0)]
	public long Next;

	[FieldOffset(8)]
	public long Prev;

	[FieldOffset(16)]
	public long String;

	[FieldOffset(24)]
	public int ComponentList;

	public override string ToString()
	{
		return $"Next: {Next} Prev: {Prev} String: {String} ComponentList: {ComponentList}";
	}
}
