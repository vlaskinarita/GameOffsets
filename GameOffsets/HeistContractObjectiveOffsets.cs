using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistContractObjectiveOffsets
{
	[FieldOffset(0)]
	public long TargetKey;

	[FieldOffset(20)]
	public long ClientKey;

	[FieldOffset(28)]
	public long Unknown1Key;
}
