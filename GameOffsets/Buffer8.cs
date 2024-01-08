using System.Runtime.CompilerServices;

namespace GameOffsets;

[InlineArray(8)]
public struct Buffer8<T>
{
	private T _element;
}
