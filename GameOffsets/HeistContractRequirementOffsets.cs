using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistContractRequirementOffsets
{
	[FieldOffset(0)]
	public long JobKey;

	[FieldOffset(16)]
	public byte JobLevel;
}
