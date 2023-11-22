using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerStashTabOffsets
{
	public const int StructSize = 104;

	[FieldOffset(8)]
	public NativeStringU Name;

	[FieldOffset(44)]
	public uint Color;

	[FieldOffset(52)]
	public uint OfficerFlags;

	[FieldOffset(52)]
	public uint TabType;

	[FieldOffset(56)]
	public ushort DisplayIndex;

	[FieldOffset(60)]
	public uint MemberFlags;

	[FieldOffset(61)]
	public byte Flags;
}
