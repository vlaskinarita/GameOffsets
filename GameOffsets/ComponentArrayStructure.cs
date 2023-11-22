using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ComponentArrayStructure
{
	public byte Flag0;

	public byte Flag1;

	public byte Flag2;

	public byte Flag3;

	public byte Flag4;

	public byte Flag5;

	public byte Flag6;

	public byte Flag7;

	public ComponentNameAndIndexStruct Pointer0;

	public ComponentNameAndIndexStruct Pointer1;

	public ComponentNameAndIndexStruct Pointer2;

	public ComponentNameAndIndexStruct Pointer3;

	public ComponentNameAndIndexStruct Pointer4;

	public ComponentNameAndIndexStruct Pointer5;

	public ComponentNameAndIndexStruct Pointer6;

	public ComponentNameAndIndexStruct Pointer7;

	public static byte InValidPointerFlagValue = byte.MaxValue;
}
