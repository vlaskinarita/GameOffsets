using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Sockets
{
	public ComponentHeader Header;

	public long UselessPtr;

	public SocketColors Colors;

	public SocketGems Gems;

	public NativePtrArray ListsPtr;
}
