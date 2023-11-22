using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 8)]
public struct Type5EnvironmentSettingsOffsets
{
	[FieldOffset(0)]
	public byte Value;

	[FieldOffset(1)]
	public byte Override;

	public override string ToString()
	{
		return $"{Value}, {Override}";
	}
}
