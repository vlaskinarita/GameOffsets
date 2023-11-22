using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumFloorWindowDataOffsets
{
	public const long OutOfSanctumFloorDataOffset = 352L;

	public const long InSanctumFloorDataType1Offset = 480L;

	public const long InSanctumFloorDataType2Offset = 408L;

	public const long InspirationOffset = 84L;

	public const long MaxResolveOffset = 82L;

	public const long CurrentResolveOffset = 80L;

	public const long GoldOffset = 72L;

	public const long RoomChoiceHistoryOffset = 56L;

	public const long RewardArrayOffset = 104L;

	[FieldOffset(641)]
	public bool Flag1;

	[FieldOffset(642)]
	public bool Flag2;
}
