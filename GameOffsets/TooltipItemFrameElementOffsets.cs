using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TooltipItemFrameElementOffsets
{
	[FieldOffset(640)]
	public long CopyTextPtr;

	[FieldOffset(672)]
	public bool IsAdvancedTooltipText;
}
