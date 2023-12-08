using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaLoadingStateOffsets
{
	[FieldOffset(328)]
	public long IsLoading;

	[FieldOffset(1024)]
	public uint TotalLoadingScreenTimeMs;

	[FieldOffset(904)]
	public long AreaName;
}
