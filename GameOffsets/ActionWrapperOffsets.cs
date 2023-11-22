using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActionWrapperOffsets
{
	[FieldOffset(200)]
	public long Skill;

	[FieldOffset(248)]
	public long Target;

	[FieldOffset(256)]
	public Vector2i Destination;
}
