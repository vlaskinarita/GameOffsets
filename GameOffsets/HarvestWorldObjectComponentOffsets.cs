using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestWorldObjectComponentOffsets
{
	[FieldOffset(32)]
	public StdVector Seeds;
}
