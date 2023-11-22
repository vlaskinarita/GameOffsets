using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillGem
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(32)]
	public long SkillGemInternalPtr;

	[FieldOffset(40)]
	public uint TotalExpGained;

	[FieldOffset(44)]
	public uint Level;

	[FieldOffset(48)]
	public uint ExperiencePrevLevel;

	[FieldOffset(52)]
	public uint ExperienceMaxLevel;
}
