using System;

namespace MemoryComparison
{
    public class SpanComparison : IComparison
    {
        public unsafe bool Compare(byte[] A, byte[] B)
        {
            var a = new ReadOnlySpan<byte>(A);
            var b = new ReadOnlySpan<byte>(B);
            return a.SequenceEqual(b);
        }
    }
}
