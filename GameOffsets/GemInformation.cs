using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GemInformation
{
	[FieldOffset(16)]
	public int SocketColor;

	[FieldOffset(40)]
	public int MaxLevel;

	[FieldOffset(44)]
	public int LimitLevel;

	[FieldOffset(56)]
	public long GrantedEffect1;

	[FieldOffset(72)]
	public long GrantedEffect1HardMode;

	[FieldOffset(88)]
	public long GrantedEffect2;

	[FieldOffset(104)]
	public long GrantedEffect2HardMode;
}
