using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorDeployedObject
{
	[FieldOffset(0)]
	public ushort do_id;

	[FieldOffset(2)]
	public ushort SkillId;

	[FieldOffset(4)]
	public ushort ObjectId; //InstanceId

    [FieldOffset(6)]
	public ushort Padding;
}
