using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UnorderedMapNode<TKey, TValue> where TKey : unmanaged where TValue : unmanaged
{
	public long PreviousNodePtr;

	public long NextNodePtr;

	public TKey Key;

	public TValue Value;
}
