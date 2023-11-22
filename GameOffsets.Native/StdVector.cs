using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets.Native;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdVector
{
	public long First;

	public long Last;

	public long End;

	public long TotalElements(int elementSize)
	{
		return (Last - First) / elementSize;
	}

	public long ElementCount<T>() where T : unmanaged
	{
		return TotalElements(Unsafe.SizeOf<T>());
	}

	public override string ToString()
	{
		return $"First: {First:X} - Last: {Last:X} - Size (bytes): {TotalElements(1)}";
	}
}
