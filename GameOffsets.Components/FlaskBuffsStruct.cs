using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FlaskBuffsStruct
{
	[FieldOffset(0)]
	public long IsValidPtr;

	[FieldOffset(8)]
	public long BuffIdStringPtr;

	[FieldOffset(16)]
	public NativePtrArray BuffValuePtr;
}
