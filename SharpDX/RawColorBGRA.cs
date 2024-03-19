
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace GameOffsets.SharpDX;

/// <summary>
/// Interop type for a ColorBGRA (BGRA, 4 bytes).
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 4)]
[DebuggerDisplay("R:{R} G:{G} B:{B} A:{A}")]
public struct RawColorBGRA
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RawColorBGRA"/> struct.
    /// </summary>
    /// <param name="b">The b.</param>
    /// <param name="g">The g.</param>
    /// <param name="r">The r.</param>
    /// <param name="a">A.</param>
    public RawColorBGRA(byte b, byte g, byte r, byte a)
    {
        B = b;
        G = g;
        R = r;
        A = a;
    }

    /// <summary>
    /// The blue component of the color.
    /// </summary>
    public byte B;

    /// <summary>
    /// The green component of the color.
    /// </summary>
    public byte G;

    /// <summary>
    /// The red component of the color.
    /// </summary>
    public byte R;

    /// <summary>
    /// The alpha component of the color.
    /// </summary>
    public byte A;
}