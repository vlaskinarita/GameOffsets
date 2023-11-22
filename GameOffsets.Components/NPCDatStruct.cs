using System.Runtime.InteropServices;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCDatStruct
{
	[FieldOffset(0)]
	public long IdStringPtr;

	[FieldOffset(8)]
	public long NamePtr;

	[FieldOffset(16)]
	public long MetadataPtr;

	[FieldOffset(24)]
	public int Unknown0;

	[FieldOffset(36)]
	public long NpcMasterPtr;

	[FieldOffset(44)]
	public long ShortNamePtr;

	[FieldOffset(52)]
	public int Act;
}
