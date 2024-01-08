using System.Runtime.InteropServices;
using System.Text;

namespace GameOffsets;
// TODO what is this? consider chooisng a better name?
[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NativeStringU {
    //its totale 16byte buffer to read words shorter than 1-8 letters, 2 bytes per letter
    [FieldOffset(0x0)] public long buf;
    [FieldOffset(0x8)] public long buf2;
    [FieldOffset(0x10)] public uint Size;
    [FieldOffset(0x18)] public uint Capacity;

    public string GetVaue() {
        //if (Capacity >= 8) {
        //    if (Size < 256)
        //        return ui.m.ReadStringU(buf, (int)Size * 2);

        //    return ui.m.ReadStringU(buf);
        //}
        //return Encoding.Unicode.GetString(BitConverter.GetBytes(buf).Concat(BitConverter.GetBytes(buf2))
        //    .Take((int)Size * 2).ToArray());
        return "Error load";
    }
}