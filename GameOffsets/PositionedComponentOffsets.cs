using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PositionedComponentOffsets
{
	[FieldOffset(8)]
	public long OwnerAddress;

	[FieldOffset(480)]
	public byte Reaction;

	[FieldOffset(580)]
	public Vector2 PrevPosition;

	[FieldOffset(592)]
	public Vector2 RelativeCoord;

	[FieldOffset(656)]
	public Vector2i GridPosition;

	[FieldOffset(664)]
	public float Rotation;

	[FieldOffset(684)]
	public float Scale;

	[FieldOffset(485)]
	public int Size;

	[FieldOffset(692)]
	public Vector2 WorldPosition;
}
