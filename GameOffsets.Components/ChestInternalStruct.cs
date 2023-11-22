using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ChestInternalStruct
{
	[FieldOffset(80)]
	public long StrongboxesPtr;
}
