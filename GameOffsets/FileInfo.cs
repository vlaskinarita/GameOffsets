using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FileInfo
{
	[FieldOffset(8)]
	public long Name;

	[FieldOffset(48)]
	public long Records;

	[FieldOffset(64)]
	public int AreaChangeCount;
}
