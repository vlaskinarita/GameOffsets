using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CursorOffsets
{
	[FieldOffset(0)]
	public int vTable;

	[FieldOffset(588)]
	public int Clicks;

	[FieldOffset(1232)]
	public int Action;

	[FieldOffset(1392)]
	public NativeUtf16Text ActionString;
}
