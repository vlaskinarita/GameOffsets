using System;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VitalStruct
{
	[FieldOffset(40)]
	public float Regen;

	[FieldOffset(44)]
	public int Max;

	[FieldOffset(48)]
	public int Current;

	[FieldOffset(16)]
	public int ReservedFlat;

	[FieldOffset(20)]
	public int ReservedFraction;

	public int Reserved => (int)Math.Ceiling((double)ReservedFraction / 10000.0 * (double)Max) + ReservedFlat;

	public int Unreserved => Max - Reserved;
}
