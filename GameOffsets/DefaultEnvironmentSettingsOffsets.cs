using System.Numerics;
using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DefaultEnvironmentSettingsOffsets
{
	[FieldOffset(8)]
	public NativeUtf16Text Category;

	[FieldOffset(40)]
	public NativeUtf16Text Name;

	[FieldOffset(72)]
	public int IndexInGroup;

	[FieldOffset(76)]
	public Vector3 Value;
}
