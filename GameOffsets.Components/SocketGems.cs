using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SocketGems
{
	public long S1GemPtr;

	public long S2GemPtr;

	public long S3GemPtr;

	public long S4GemPtr;

	public long S5GemPtr;

	public long S6GemPtr;
}
