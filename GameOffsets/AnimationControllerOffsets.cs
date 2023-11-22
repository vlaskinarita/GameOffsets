using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AnimationControllerOffsets
{
	[FieldOffset(24)]
	public NativePtrArray ActiveAnimationsArrayPtr;

	[FieldOffset(376)]
	public long ActorAnimationArrayPtr;

	[FieldOffset(392)]
	public int AnimationInActorId;

	[FieldOffset(408)]
	public float AnimationProgress;

	[FieldOffset(412)]
	public int CurrentAnimationStage;

	[FieldOffset(416)]
	public float NextAnimationPoint;

	[FieldOffset(420)]
	public float AnimationSpeedMultiplier1;

	[FieldOffset(464)]
	public float AnimationSpeedMultiplier2;

	[FieldOffset(428)]
	public float MaxAnimationProgressOffset;

	[FieldOffset(432)]
	public float MaxAnimationProgress;
}
