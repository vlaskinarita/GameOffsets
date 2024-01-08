using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumPanelOffsets
{
	[FieldOffset(640)]
	public StdVector OfferedModifiers;

	[FieldOffset(664)]
	public int SelectedModifierIndex;
}
