using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistContractComponentOffsets
{
	[FieldOffset(8)]
	public long Owner;

	[FieldOffset(32)]
	public long ObjectiveKey;

	[FieldOffset(48)]
	public NativePtrArray Requirements;

	[FieldOffset(56)]
	public NativePtrArray Crew;
}
