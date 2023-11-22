using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemInfoOffsets
{
	[FieldOffset(16)]
	public byte ItemCellsSizeX;

	[FieldOffset(17)]
	public byte ItemCellsSizeY;

	[FieldOffset(48)]
	public NativeStringU Name;

	[FieldOffset(56)]
	public NativeStringU FlavourText;

	[FieldOffset(104)]
	public long BaseItemType;

	[FieldOffset(112)]
	public NativePtrArray Tags;
}
