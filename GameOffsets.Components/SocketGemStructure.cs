using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SocketGemStructure
{
	public ComponentHeader Header;

	public NativePtrArray Unknown0Ptr;
}
