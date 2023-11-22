using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SocketedGemList
{
	public long Socket1GemPtr;

	public long Socket2GemPtr;

	public long Socket3GemPtr;

	public long Socket4GemPtr;

	public long Socket5GemPtr;

	public long Socket6GemPtr;
}
