using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TgtDetailStruct
{
	[FieldOffset(0)]
	public NativeStringU name;
}
