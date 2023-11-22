using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SocketsComponentOffsets
{
	[FieldOffset(24)]
	public SocketColorList Sockets;

	[FieldOffset(48)]
	public SocketedGemList SocketedGems;

	[FieldOffset(96)]
	public StdVector LinkSizes;
}
