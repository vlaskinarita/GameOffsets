using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumFloorWindowOffsets
{
	[FieldOffset(736)]
	public long InSanctumDataPtr;

	[FieldOffset(752)]
	public long OutOfSanctumDataPtr;
}
