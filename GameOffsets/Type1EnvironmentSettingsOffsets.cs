using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 8)]
public struct Type1EnvironmentSettingsOffsets
{
	[FieldOffset(0)]
	public float Value;

	[FieldOffset(4)]
	public byte Override;

	public override string ToString()
	{
		return $"{Value}, {Override}";
	}
}
