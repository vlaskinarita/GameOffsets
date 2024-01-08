using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 168)]
public struct ServerDataMinimapIconOffsets
{
	[FieldOffset(20)]
	private Vector2i GridPosition;
}
