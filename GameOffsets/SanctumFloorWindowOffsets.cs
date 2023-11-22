using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumFloorWindowOffsets
{
	[FieldOffset(720)]
	public long InSanctumDataPtr;

	[FieldOffset(736)]
	public long OutOfSanctumDataPtr;
}
