using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FlaskInfoStruct
{
	[FieldOffset(4)]
	public int LifePerUse;

	[FieldOffset(12)]
	public int ManaPerUse;

	[FieldOffset(20)]
	public int RecoveryTime;
}
