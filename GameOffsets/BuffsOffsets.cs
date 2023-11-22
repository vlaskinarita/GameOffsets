using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffsOffsets
{
	[FieldOffset(352)]
	public NativePtrArray Buffs;
}
