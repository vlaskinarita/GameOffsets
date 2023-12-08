using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffOffsets
{
	[FieldOffset(8)]
	public long BuffDatPtr;

	[FieldOffset(24)]
	public float MaxTime;

	[FieldOffset(28)]
	public float Timer;

	[FieldOffset(66)]
	public ushort Charges;
}
