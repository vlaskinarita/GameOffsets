using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ShrineBuffDatStruct
{
	[FieldOffset(0)]
	public long IdString;

	[FieldOffset(8)]
	public long BuffStatTotalKeys;

	[FieldOffset(16)]
	public long BuffStatValuesPtr;

	[FieldOffset(32)]
	public long BuffDefinationRowPtr;
}
