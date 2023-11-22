using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestStateOffsets
{
	[FieldOffset(0)]
	public long QuestAddress;

	[FieldOffset(24)]
	public long Base;

	[FieldOffset(16)]
	public byte QuestStateId;

	[FieldOffset(52)]
	public long QuestStateTextAddress;

	[FieldOffset(60)]
	public long QuestProgressTextAddress;
}
