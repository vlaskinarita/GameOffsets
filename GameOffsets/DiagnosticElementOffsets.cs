using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DiagnosticElementOffsets
{
	[FieldOffset(0)]
	public long DiagnosticArray;

	[FieldOffset(16)]
	public int X;

	[FieldOffset(20)]
	public int Y;

	[FieldOffset(24)]
	public int Width;

	[FieldOffset(28)]
	public int Height;
}
