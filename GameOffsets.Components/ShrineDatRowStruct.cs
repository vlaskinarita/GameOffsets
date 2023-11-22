using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ShrineDatRowStruct
{
	[FieldOffset(0)]
	public long IdString;

	[FieldOffset(8)]
	public int TimeoutInSeconds;

	[FieldOffset(12)]
	public long DisplayName;

	[FieldOffset(20)]
	public bool IsRegain;

	[FieldOffset(29)]
	public bool PlayerShrineBuffDatRowPtr;

	[FieldOffset(37)]
	public int Unknown0;

	[FieldOffset(41)]
	public int Unknown1;

	[FieldOffset(45)]
	public long Description;

	[FieldOffset(53)]
	public long MonsterShrineBuffDatRowPtr;
}
