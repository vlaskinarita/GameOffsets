using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ChestComponentOffsets
{
	[FieldOffset(352)]
	public long StrongboxData;

	[FieldOffset(360)]
	public bool IsOpened;

	[FieldOffset(361)]
	public bool IsLocked;

	[FieldOffset(364)]
	public readonly byte quality;

	[FieldOffset(424)]
	public bool IsStrongbox;
}
