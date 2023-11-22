using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Actor
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(248)]
	public short ActionId;

	[FieldOffset(288)]
	public int AnimationId;

	[FieldOffset(1000)]
	public NativePtrArray ActorSkillsArray;

	[FieldOffset(1104)]
	public NativePtrArray DeployedObjectArray;
}
