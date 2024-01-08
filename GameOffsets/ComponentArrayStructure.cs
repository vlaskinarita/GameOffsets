using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ComponentArrayStructure
{
	public Buffer8<byte> Flags;

	public Buffer8<ComponentNameAndIndexStruct> Pointers;

	public const byte InvalidPointerFlagValue = byte.MaxValue;
}
