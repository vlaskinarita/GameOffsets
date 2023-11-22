using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Stats
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(152)]
	public NativePtrArray StatsPtr;
}
