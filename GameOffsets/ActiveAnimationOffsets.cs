using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActiveAnimationOffsets
{
	[FieldOffset(16)]
	public int AnimationId;

	[FieldOffset(72)]
	public float SlowAnimationSpeed;

	[FieldOffset(76)]
	public float NormalAnimationSpeed;

	[FieldOffset(56)]
	public long SlowAnimationStartStagePtr;

	[FieldOffset(64)]
	public long SlowAnimationEndStagePtr;
}
