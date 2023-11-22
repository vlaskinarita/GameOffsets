using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StackInternalStructure
{
	[FieldOffset(24)]
	public long CurrencyItemsDatPtr;

	[FieldOffset(32)]
	public int MaxStackSizeInCurrencyStashTab;

	[FieldOffset(36)]
	public int Unknown1;

	[FieldOffset(40)]
	public int MaxStackSize;
}
