using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PathfindingComponentOffsets
{
	public static int PathNodeStart = 212;

	[FieldOffset(1304)]
	public int DestinationNodes;

	[FieldOffset(1360)]
	public Vector2i WantMoveToPosition;

	[FieldOffset(1372)]
	public float StayTime;
}
