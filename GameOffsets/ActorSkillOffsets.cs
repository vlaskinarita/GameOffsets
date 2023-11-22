using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorSkillOffsets
{
	[FieldOffset(8)]
	public byte SkillUseStage;

	[FieldOffset(12)]
	public byte CastType;

	[FieldOffset(16)]
	public SubActorSkillOffsets SubData;
}
