using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActorComponentOffsets
{
	[FieldOffset(416)]
	public long AnimationControllerPtr;

	[FieldOffset(432)]
	public long ActionPtr;

	[FieldOffset(528)]
	public short ActionId;

	[FieldOffset(572)]
	public int AnimationId;

	[FieldOffset(1728)]
	public NativePtrArray ActorSkillsArray;

	[FieldOffset(1752)]
	public NativePtrArray ActorSkillsCooldownArray;

	[FieldOffset(1776)]
	public NativePtrArray ActorVaalSkills;

	[FieldOffset(1800)]
	public NativePtrArray DeployedObjectArray;
}
