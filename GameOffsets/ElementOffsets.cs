using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;
using SharpDX;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ElementOffsets
{
	public const int OffsetBuffers = 0;

	[FieldOffset(40)]
	public long SelfPointer;

	[FieldOffset(48)]
	public long ChildStart;

	[FieldOffset(48)]
	public NativePtrArray Childs;

	[FieldOffset(56)]
	public long ChildEnd;

	[FieldOffset(168)]
	public Vector2 ScrollOffset;

	[FieldOffset(208)]
	public ushort Type;

	[FieldOffset(216)]
	public long Root;

	[FieldOffset(192)]
	public long Parent;

	[FieldOffset(200)]
	public Vector2 Position;

	[FieldOffset(344)]
	public long Tooltip;

	[FieldOffset(285)]
	public long IsSelected;

	[FieldOffset(456)]
	public bool isHighlighted;

	[FieldOffset(280)]
	public float Scale;

	[FieldOffset(324)]
	public ElementFlags Flags;

	[FieldOffset(400)]
	public Vector2 Size;

	[FieldOffset(515)]
	public byte ShinyHighlightState;

	[FieldOffset(1248)]
	public ColorBGRA LabelTextColor;

	[FieldOffset(456)]
	public ColorBGRA LabelBorderColor;

	[FieldOffset(1772)]
	public ColorBGRA LabelBackgroundColor;

	[FieldOffset(760)]
	public NativeUtf16Text Text;

	[FieldOffset(1056)]
	public NativeUtf16Text TextNoTags;
}
