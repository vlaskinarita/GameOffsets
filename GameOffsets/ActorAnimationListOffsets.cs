using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorAnimationListOffsets
{
	[FieldOffset(16)]
	public NativePtrArray AnimationList;
}
