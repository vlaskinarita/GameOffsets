using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterInternalStruct
{
	[FieldOffset(8)]
	public long UnknownStructPtr;

	[FieldOffset(24)]
	public long MonsterVarietiesPtr;

	[FieldOffset(32)]
	public int Level;
}
