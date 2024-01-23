using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TreePassiveElementOffsets
{
	[FieldOffset(504)]
	public long PassiveSkillPtr;

	[FieldOffset(1298)]
	public byte IsAllocatedForPlan;

	[FieldOffset(1299)]
	public byte CanAllocate;

	[FieldOffset(1302)]
	public byte CanDeallocate;
}
