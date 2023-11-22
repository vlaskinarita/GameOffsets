using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillGemOffsets
{
	[FieldOffset(0)]
	public InitObjectOffsets Head;

	[FieldOffset(32)]
	public long AdvanceInformation;

	[FieldOffset(40)]
	public uint TotalExpGained;

	[FieldOffset(44)]
	public uint Level;

	[FieldOffset(48)]
	public uint ExperiencePrevLevel;

	[FieldOffset(52)]
	public uint ExperienceMaxLevel;

	[FieldOffset(60)]
	public uint QualityType;
}
