using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EnvironmentOffsets
{
	[FieldOffset(0)]
	public ushort Key;

	[FieldOffset(2)]
	public ushort Value0;

	[FieldOffset(4)]
	public float Value1;
}
