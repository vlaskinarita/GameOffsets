using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PathEntityOffsets
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct StringPtr
	{
		[FieldOffset(0)]
		public long Ptr;
	}

	[FieldOffset(8)]
	public StringPtr Path;

	[FieldOffset(32)]
	public long Length;
}
