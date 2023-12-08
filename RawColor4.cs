using System.Diagnostics;
using System.Runtime.InteropServices;
namespace GameOffsets;

/// <summary>
/// Interop type for a Color4 (RGBA, 4 floats).
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
[DebuggerDisplay("R:{R} G:{G} B:{B} A:{A}")]
public struct RawColor4 {
    /// <summary>
    /// Initializes a new instance of the <see cref="RawColor4"/> struct.
    /// </summary>
    /// <param name="r">The r.</param>
    /// <param name="g">The g.</param>
    /// <param name="b">The b.</param>
    /// <param name="a">A.</param>
    public RawColor4(float r, float g, float b, float a) {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    /// <summary>
    /// The red component of the color.
    /// </summary>
    public float R;

    /// <summary>
    /// The green component of the color.
    /// </summary>
    public float G;

    /// <summary>
    /// The blue component of the color.
    /// </summary>
    public float B;

    /// <summary>
    /// The alpha component of the color.
    /// </summary>
    public float A;
}