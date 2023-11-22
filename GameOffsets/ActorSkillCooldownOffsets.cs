using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorSkillCooldownOffsets
{
	[FieldOffset(8)]
	public int SkillSubId;

	[FieldOffset(16)]
	public StdVector Cooldowns;

	[FieldOffset(48)]
	public int MaxUses;

	[FieldOffset(60)]
	public ushort SkillId;
}
