using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorAnimationStageOffsets
{
	[FieldOffset(4)]
	public float StageStart;

	[FieldOffset(8)]
	public int ActorAnimationListIndex;

	[FieldOffset(24)]
	public NativeUtf8Text StageName;
}
