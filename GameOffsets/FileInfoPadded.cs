using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FileInfoPadded
{
	[FieldOffset(16)]
	public FileInfo FileInfo;
}
