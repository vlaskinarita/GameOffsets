using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SocketColorList
{
	public int Socket1Color;

	public int Socket2Color;

	public int Socket3Color;

	public int Socket4Color;

	public int Socket5Color;

	public int Socket6Color;
}
