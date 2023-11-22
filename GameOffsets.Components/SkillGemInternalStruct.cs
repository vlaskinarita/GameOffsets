using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillGemInternalStruct
{
	[FieldOffset(48)]
	public int SocketColor;

	[FieldOffset(64)]
	public long SkillGemDatPtr;

	[FieldOffset(72)]
	public int MaxLevel;

	[FieldOffset(76)]
	public int LimitLevel;
}
