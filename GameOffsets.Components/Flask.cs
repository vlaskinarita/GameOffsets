using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets.Components;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Flask
{
	[FieldOffset(0)]
	public ComponentHeader Header;

	[FieldOffset(16)]
	public NativePtrArray ExtraBuffsDueToModsPtr;

	[FieldOffset(40)]
	public long FlaskInternalPtr;
}
