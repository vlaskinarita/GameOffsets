using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StrongboxChestComponentData
{
	[FieldOffset(32)]
	public bool DestroyingAfterOpen;

	[FieldOffset(33)]
	public bool IsLarge;

	[FieldOffset(34)]
	public bool Stompable;

	[FieldOffset(37)]
	public bool OpenOnDamage;
}
