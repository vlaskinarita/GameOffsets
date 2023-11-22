using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterVarietiesStruct
{
	[FieldOffset(0)]
	public long IdStringPtr;

	[FieldOffset(16)]
	public long MonsterTypePtr;

	[FieldOffset(32)]
	public MinMaxStruct AttackDistance;

	[FieldOffset(64)]
	public long TotalMods;

	[FieldOffset(72)]
	public long ModsPtr;

	[FieldOffset(244)]
	public long MonsterName;
}
