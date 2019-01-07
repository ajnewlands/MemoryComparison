using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace MemoryComparison
{
    public class ForInt64Comparison: IComparison
    {
        // The fastest pure c# version so far...
        // N.B. this assumes that the array length is a multiple of 8.
        // In reality, it would be necessary to handle any overhang (i.e. the trailing 0-7 bytes at the end)!
        public unsafe bool Compare(byte[]A, byte[]B)
        {
            if (A.Length != B.Length)
                return false;

            fixed( byte* pA = A, pB = B)
            {
                long* lA = (long*)pA;
                long* lB = (long*)pB;

                for (int i = 0; i < A.Length/8; i++)
                {
                    long a = lA[i];
                    long b = lB[i];

                    if (a != b)
                        return false;
                }
                return true;
            }
        }

    }
}
