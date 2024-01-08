
using System;
using System.Runtime.InteropServices;
namespace GameOffsets;


[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct StdVector : IEquatable<StdVector> {
    public IntPtr First;
    public IntPtr Last;
    public IntPtr End;
    public long Size => Last.ToInt64() - First.ToInt64();
    /// <summary>
    ///     Counts the number of elements in the StdVector.
    /// </summary>
    /// <param name="elementSize">Number of bytes in 1 element.</param>
    /// <returns></returns>
    public long TotalElements(int elementSize) {
        return (this.Last.ToInt64() - this.First.ToInt64()) / elementSize;
    }
    public bool Equals(StdVector other) {
        if (First == other.First && Last == other.Last)
            return End == other.End;

        return false;
    }

    public override bool Equals(object obj) {
        if (obj is StdVector other)
            return Equals(other);

        return false;
    }

    public override int GetHashCode() {
        return (((First.GetHashCode() * 397) ^ Last.GetHashCode()) * 397) ^ End.GetHashCode();
    }
    public override string ToString() {
        return $"First: {this.First.ToInt64():X} - " +
               $"Last: {this.Last.ToInt64():X} - " +
               $"Size (bytes): {this.TotalElements(1)}";
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeVector : IEquatable<NativeVector> {
    public IntPtr First;
    public IntPtr Last;
    public IntPtr End;
    public long Size => Last.ToInt64() - First.ToInt64();
    /// <summary>
    ///     Counts the number of elements in the StdVector.
    /// </summary>
    /// <param name="elementSize">Number of bytes in 1 element.</param>
    /// <returns></returns>
    public long TotalElements(int elementSize) {
        return (this.Last.ToInt64() - this.First.ToInt64()) / elementSize;
    }
    public bool Equals(NativeVector other) {
        if (First == other.First && Last == other.Last)
            return End == other.End;

        return false;
    }

    public override bool Equals(object obj) {
        if (obj is NativeVector other)
            return Equals(other);

        return false;
    }

    public override int GetHashCode() {
        return (((First.GetHashCode() * 397) ^ Last.GetHashCode()) * 397) ^ End.GetHashCode();
    }
    public override string ToString() {
        return $"First: {this.First.ToInt64():X} - " +
               $"Last: {this.Last.ToInt64():X} - " +
               $"Size (bytes): {this.TotalElements(1)}";
    }
}