using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FlaskInternalStruct
{
	[FieldOffset(24)]
	public NativePtrArray FlaskInfoPtr;

	[FieldOffset(48)]
	public int FlaskType;

	[FieldOffset(56)]
	public FlaskBuffsStruct FlaskBuffDueToType;
}
