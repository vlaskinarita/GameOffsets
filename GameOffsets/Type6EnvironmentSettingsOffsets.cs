using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 80)]
public struct Type6EnvironmentSettingsOffsets
{
	[FieldOffset(0)]
	public NativeUtf16Text Name;

	[FieldOffset(32)]
	public NativeUtf16Text Category;

	[FieldOffset(64)]
	public float Value1;

	[FieldOffset(68)]
	public float Value2;

	[FieldOffset(72)]
	public byte Override;

	public override string ToString()
	{
		return $"{Value1}, {Value2}, {Override}";
	}
}
