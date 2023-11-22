using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ComponentNameAndIndexStruct
{
	public long NamePtr;

	public int Index;

	public int deadcode;
}
