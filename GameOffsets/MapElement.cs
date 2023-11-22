using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapElement
{
	public const int LargeMapOffset = 640;

	public const int SmallMapOffset = 648;

	public const int MapPropertiesOffset = 672;

	public const int OrangeWordsOffset = 680;

	public const int BlueWordsOffset = 848;
}
