using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestorSidePanelOffsets
{
	[FieldOffset(592)]
	public long UnitPtr;

	[FieldOffset(576)]
	public long ItemPtr;
}
