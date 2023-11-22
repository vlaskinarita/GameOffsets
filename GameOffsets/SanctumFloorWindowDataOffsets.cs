using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumFloorWindowDataOffsets
{
	public const long OutOfSanctumFloorDataOffset = 352L;

	public const long InSanctumFloorDataType1Offset = 480L;

	public const long InSanctumFloorDataType2Offset = 408L;

	[FieldOffset(641)]
	public bool Flag1;

	[FieldOffset(642)]
	public bool Flag2;
}
