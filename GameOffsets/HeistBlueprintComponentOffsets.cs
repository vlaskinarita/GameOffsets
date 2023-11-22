using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistBlueprintComponentOffsets
{
	public static readonly int WingRecordSize = 80;

	public static readonly int JobRecordSize = 24;

	public static readonly int RoomRecordSize = 24;

	public static readonly int NpcRecordSize = 16;

	[FieldOffset(8)]
	public long Owner;

	[FieldOffset(28)]
	public byte AreaLevel;

	[FieldOffset(30)]
	public byte IsConfirmed;

	[FieldOffset(32)]
	public NativePtrArray Wings;
}
