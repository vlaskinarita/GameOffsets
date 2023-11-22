using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DiagnosticElementArrayOffsets
{
	[FieldOffset(316)]
	public float CurrValue;
}
