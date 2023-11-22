using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PurchaseWindowOffsets
{
	[FieldOffset(560)]
	public long StashTabContainerPtr;
}
