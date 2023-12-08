using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EnvironmentDataOffsets
{
	public const int Type1Count = 94;

	public const int Type1Size = 8;

	public const int Type1Offset = 0;

	public const int Type2Count = 1;

	public const int Type2Size = 8;

	public const int Type2Offset = 752;

	public const int Type3Count = 8;

	public const int Type3Size = 16;

	public const int Type3Offset = 760;

	public const int Type4Count = 9;

	public const int Type4Size = 2;

	public const int Type4Offset = 888;

	public const int Type5Count = 2;

	public const int Type5Size = 8;

	public const int Type5Offset = 908;

	public const int Type6Count = 13;

	public const int Type6Size = 80;

	public const int Type6Offset = 928;

	public const int Type7Count = 1;

	public const int Type7Size = 32;

	public const int Type7Offset = 1968;

	public const int Type8Count = 1;

	public const int Type8Size = 32;

	public const int Type8Offset = 2000;

	public const int Type9Count = 1;

	public const int Type9Size = 32;

	public const int Type9Offset = 2032;

	public const int Type10Count = 1;

	public const int Type10Size = 32;

	public const int Type10Offset = 2064;

	[FieldOffset(1072)]
	public StdVector DefaultSettingsList;

	[FieldOffset(1232)]
	public StdVector ActiveEnvironmentList;

	[FieldOffset(5424)]
	public StdVector FootstepAudioList;

	public const int FirstInlineValueListOffset = 1288;

	public const int SecondInlineValueListOffset = 3384;
}
