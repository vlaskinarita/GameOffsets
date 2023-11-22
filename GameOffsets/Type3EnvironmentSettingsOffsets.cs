using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
public struct Type3EnvironmentSettingsOffsets
{
	[FieldOffset(0)]
	public Vector3 Value;

	[FieldOffset(12)]
	public byte Override;

	public override string ToString()
	{
		return $"{Value}, {Override}";
	}
}
