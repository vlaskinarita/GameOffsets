using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GemInformation
{
	[FieldOffset(16)]
	public int SocketColor;

	[FieldOffset(24)]
	public long SkillGemPtr;

	[FieldOffset(40)]
	public int MaxLevel;

	[FieldOffset(44)]
	public int LimitLevel;
}
