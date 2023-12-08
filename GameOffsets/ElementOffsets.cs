using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

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
	public System.Numerics.Vector2 ScrollOffset;

	[FieldOffset(208)]
	public ushort Type;

	[FieldOffset(216)]
	public long Root;

	[FieldOffset(224)]
	public long Parent;

	[FieldOffset(232)]
	public System.Numerics.Vector2 Position;

	[FieldOffset(264)]
	public long Tooltip;

	[FieldOffset(285)]
	public long IsSelected;

	[FieldOffset(440)]
	public bool isHighlighted;

	[FieldOffset(344)]
	public float Scale;

	[FieldOffset(352)]
	public ElementFlags Flags;

	[FieldOffset(384)]
	public System.Numerics.Vector2 Size;

	[FieldOffset(499)]
	public byte ShinyHighlightState;

	[FieldOffset(1232)]
	public ColorBGRA LabelTextColor;

	[FieldOffset(440)]
	public ColorBGRA LabelBorderColor;

	[FieldOffset(1756)]
	public ColorBGRA LabelBackgroundColor;

	[FieldOffset(744)]
	public NativeUtf16Text Text;

	[FieldOffset(1040)]
	public NativeUtf16Text TextNoTags;
}
