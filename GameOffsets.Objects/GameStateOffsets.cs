using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Objects;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GameStateOffsets
{
	[FieldOffset(8)]
	public StdVector CurrentStatePtr;

	[FieldOffset(72)]
	public long State0;

	[FieldOffset(88)]
	public long State1;

	[FieldOffset(104)]
	public long State2;

	[FieldOffset(120)]
	public long State3;

	[FieldOffset(136)]
	public long State4;

	[FieldOffset(152)]
	public long State5;

	[FieldOffset(168)]
	public long State6;

	[FieldOffset(184)]
	public long State7;

	[FieldOffset(200)]
	public long State8;

	[FieldOffset(216)]
	public long State9;

	[FieldOffset(232)]
	public long State10;

	[FieldOffset(248)]
	public long State11;
}
