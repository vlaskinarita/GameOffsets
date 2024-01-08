using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GameConfigSectionOffsets
{
	[FieldOffset(0)]
	public NativeUtf16Text SectionKey;

	[FieldOffset(32)]
	public UnorderedMap SectionMap;
}
