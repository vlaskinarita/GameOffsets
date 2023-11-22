using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ServerDataArtifacts
{
	[FieldOffset(0)]
	public ushort LesserBrokenCircleArtifacts;

	[FieldOffset(2)]
	public ushort GreaterBrokenCircleArtifacts;

	[FieldOffset(4)]
	public ushort GrandBrokenCircleArtifacts;

	[FieldOffset(6)]
	public ushort ExceptionalBrokenCircleArtifacts;

	[FieldOffset(8)]
	public ushort LesserBlackScytheArtifacts;

	[FieldOffset(10)]
	public ushort GreaterBlackScytheArtifacts;

	[FieldOffset(12)]
	public ushort GrandBlackScytheArtifacts;

	[FieldOffset(14)]
	public ushort ExceptionalBlackScytheArtifacts;

	[FieldOffset(16)]
	public ushort LesserOrderArtifacts;

	[FieldOffset(18)]
	public ushort GreaterOrderArtifacts;

	[FieldOffset(20)]
	public ushort GrandOrderArtifacts;

	[FieldOffset(22)]
	public ushort ExceptionalOrderArtifacts;

	[FieldOffset(24)]
	public ushort LesserSunArtifacts;

	[FieldOffset(26)]
	public ushort GreaterSunArtifacts;

	[FieldOffset(28)]
	public ushort GrandSunArtifacts;

	[FieldOffset(30)]
	public ushort ExceptionalSunArtifacts;
}
