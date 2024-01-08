using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
public struct ActorDeployedObjectOffsets
{
	[FieldOffset(0)]
	public uint EntityId;

	[FieldOffset(4)]
	public ushort SkillId;

	[FieldOffset(8)]
	public uint ObjectType;
}
