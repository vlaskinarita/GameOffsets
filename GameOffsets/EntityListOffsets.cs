using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EntityListOffsets
{
	[FieldOffset(0)]
	public long FirstAddr;

	[FieldOffset(16)]
	public long SecondAddr;

	[FieldOffset(40)]
	public long Entity;
}
