using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
public struct Type7PlusEnvironmentSettingsOffsets
{
	[FieldOffset(0)]
	public Vector4 Value;

	[FieldOffset(64)]
	public Vector4 Value2;

	public override string ToString()
	{
		return $"{Value}, {Value2}";
	}
}
