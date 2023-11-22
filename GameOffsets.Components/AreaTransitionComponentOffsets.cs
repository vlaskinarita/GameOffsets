using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaTransitionComponentOffsets
{
	[FieldOffset(40)]
	public ushort AreaId;

	[FieldOffset(42)]
	public byte TransitionType;

	[FieldOffset(72)]
	public long WorldAreaInfoPtr;
}
