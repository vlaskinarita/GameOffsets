using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorDeployedObject
{
	[FieldOffset(0)]
	public ushort Unknown1;

	[FieldOffset(2)]
	public ushort SkillId;

	[FieldOffset(4)]
	public ushort ObjectId;

	[FieldOffset(6)]
	public ushort Unknown2;
}
