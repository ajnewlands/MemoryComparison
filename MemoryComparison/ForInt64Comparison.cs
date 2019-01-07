using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace MemoryComparison
{
    public class ForInt64Comparison: IComparison
    {
        // NB, implicitly assuming both arrays are the same length and the length is divisible by 8 (bytes)
        public unsafe bool Compare(byte[]A, byte[]B)
        {
            var pA = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(A, 0);
            var pB = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(B, 0);

            for(int i = 0; i < A.Length; i = i + 8)
            {

                if (Marshal.ReadInt64(pA) != Marshal.ReadInt64(pB))
                    return false;
            }
            return true;
        }
    }
}
