using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionSagaOffsets
{
	[FieldOffset(48)]
	public byte AreaLevel;

	[FieldOffset(24)]
	public NativePtrArray AreasData;
}
