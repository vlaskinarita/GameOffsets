using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ObjectHeaderOffsets
{
	[FieldOffset(0)]
	public long MainObject;

	[FieldOffset(8)]
	public long Name;

	[FieldOffset(48)]
	public long ComponentLookUpPtr;

	public override string ToString()
	{
		return $"MainObject: {MainObject} ComponentList:{ComponentLookUpPtr}";
	}
}
