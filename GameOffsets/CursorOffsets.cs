using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CursorOffsets
{
	public const int OffsetBuffers = 1772;

	[FieldOffset(0)]
	public int vTable;

	[FieldOffset(568)]
	public int Action;

	[FieldOffset(588)]
	public int Clicks;

	[FieldOffset(672)]
	public NativeStringU ActionString;
}
