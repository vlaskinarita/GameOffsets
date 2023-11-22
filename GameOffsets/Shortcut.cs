using System;
using System.Runtime.InteropServices;

namespace GameOffsets;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
public struct Shortcut
{
	[FieldOffset(0)]
	public ConsoleKey MainKey;

	[FieldOffset(4)]
	public ShortcutModifier Modifier;

	[FieldOffset(8)]
	public ShortcutUsage Usage;

	public string ModifierText
	{
		get
		{
			if (Modifier != 0)
			{
				return $"{Modifier} + ";
			}
			return null;
		}
	}

	public override string ToString()
	{
		return $"{ModifierText}{MainKey} ({Usage})";
	}
}
