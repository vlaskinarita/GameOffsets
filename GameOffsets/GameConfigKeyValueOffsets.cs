using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GameConfigKeyValueOffsets
{
	[FieldOffset(0)]
	public NativeUtf16Text Key;

	[FieldOffset(32)]
	public NativeUtf16Text Value;
}
