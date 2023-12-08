using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TooltipItemFrameElementOffsets
{
	[FieldOffset(656)]
	public long CopyTextPtr;

	[FieldOffset(688)]
	public bool IsAdvancedTooltipText;
}
