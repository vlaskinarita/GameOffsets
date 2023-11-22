using System;

namespace GameOffsets;

[Flags]
public enum ElementFlags : uint
{
	IsScrollable = 0x400u,
	IsVisibleLocal = 0x800u,
	Flag0 = 1u,
	Flag1 = 2u,
	Flag2 = 4u,
	Flag3 = 8u,
	Flag4 = 0x10u,
	Flag5 = 0x20u,
	Flag6 = 0x40u,
	Flag7 = 0x80u,
	Flag8 = 0x100u,
	Flag9 = 0x200u,
	Flag12 = 0x1000u,
	Flag13 = 0x2000u,
	Flag14 = 0x4000u,
	Flag15 = 0x8000u,
	Flag16 = 0x10000u,
	Flag17 = 0x20000u,
	Flag18 = 0x40000u,
	Flag19 = 0x80000u,
	Flag20 = 0x100000u,
	Flag21 = 0x200000u,
	Flag22 = 0x400000u,
	Flag23 = 0x800000u,
	Flag24 = 0x1000000u,
	Flag25 = 0x2000000u,
	Flag26 = 0x4000000u,
	Flag27 = 0x8000000u,
	Flag28 = 0x10000000u,
	Flag29 = 0x20000000u,
	Flag30 = 0x40000000u,
	Flag31 = 0x80000000u
}
