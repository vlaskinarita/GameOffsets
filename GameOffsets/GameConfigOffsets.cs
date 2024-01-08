using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GameConfigOffsets
{
	[FieldOffset(392)]
	public UnorderedMap ConfigMap;
}
