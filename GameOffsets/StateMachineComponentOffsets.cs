using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StateMachineComponentOffsets
{
	[FieldOffset(344)]
	public long StatesPtr;

	[FieldOffset(352)]
	public NativePtrArray StatesValues;
}
