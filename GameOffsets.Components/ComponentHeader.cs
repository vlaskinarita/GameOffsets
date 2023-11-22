using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ComponentHeader
{
	[FieldOffset(0)]
	public long StaticPtr;

	[FieldOffset(8)]
	public long EntityPtr;
}
