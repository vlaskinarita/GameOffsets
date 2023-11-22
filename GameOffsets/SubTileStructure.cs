using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SubTileStructure
{
	public StdVector SubTileHeight;
}
