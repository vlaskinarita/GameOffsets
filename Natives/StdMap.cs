using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
namespace GameOffsets; 

/// <summary>
///     A structure to read the c++ stdmap stored in the memory.
///     NOTE: A reader function that uses this datastructure exists
///     in SafeMemoryHandle class. If you modify this datastructure
///     modify that too.
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdMap {
    public IntPtr Head;
    public int Size; // according to debugger this is long but for now int is working fine.
    public int PAD_C;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeMap {//DPB 
    public long Head;
    public uint Size;
    public override string ToString() {
        return string.Format("Head: 0x{0}, Size: 0x{1}", Head.ToString("X"), Size);
    }
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdMapNode<TKey, TValue> where TKey : struct where TValue : struct {
    public IntPtr Left; // 0x00
    public IntPtr Parent; // 0x08
    public IntPtr Right; // 0x10
    public byte Color; // 0x18
    public bool IsNil; // 0x19
    public byte pad_1A;
    public byte pad_1B;
    public uint pad_1C;
    public StdMapNodeData<TKey, TValue> Data; // 0x20
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdMapNodeData<TKey, TValue> where TKey : struct  where TValue : struct {
    public TKey Key;
    public TValue Value;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeHashMap {
    public readonly int Proxy;
    public readonly int unusedInt0;
    public readonly NativeList List;
    public readonly StdVector Vector;
    public readonly int Mask;
    public readonly int unusedInt1;
    public readonly int MaxIdx;
    public readonly int unusedInt2;

}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeList {
    public readonly long Head;
    public readonly uint Size;
    public readonly int unusedInt0;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeStringWCustom : IEquatable<NativeStringWCustom> {
    public bool Equals(NativeStringWCustom other) {
        if (this.ReservedSize != other.ReservedSize) {
            return false;
        }
        if (this.Size != other.Size) {
            return false;
        }
        if (8U <= this.ReservedSize) {
            //string text = ui.m.ReadStringU(this.Buf.Address, 512, true);
            //string value = ui.m.ReadStringU(other.Buf.Address, 512, true);
            //return text.Equals(value);
            return false; // "error loading here";
        }
        byte[] bytes = BitConverter.GetBytes(this.Buf.Address);
        byte[] bytes2 = BitConverter.GetBytes(this.Buf.Address2);
        byte[] bytes3 = bytes.Concat(bytes2).ToArray<byte>();
        string text2 = Encoding.Unicode.GetString(bytes3).Substring(0, (int)other.Size);
        byte[] bytes4 = BitConverter.GetBytes(other.Buf.Address);
        byte[] bytes5 = BitConverter.GetBytes(other.Buf.Address2);
        byte[] bytes6 = bytes4.Concat(bytes5).ToArray<byte>();
        string value2 = Encoding.Unicode.GetString(bytes6).Substring(0, (int)other.Size);
        return text2.Equals(value2);
    }

    public Bufe__FixedBuffer Buf;

    public readonly uint Size;

    public readonly uint Sizeunused;

    public readonly uint ReservedSize;

    public readonly uint ReservedSizeunused;

    [CompilerGenerated]
    [UnsafeValueType]
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct Bufe__FixedBuffer {
        public long Address;

        public long Address2;
    }
}