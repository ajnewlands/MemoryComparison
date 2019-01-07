using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace MemoryComparison
{
    public class ForInt64Comparison: IComparison
    {
        // The fastest pure c# version so far...
        public unsafe bool Compare(byte[]A, byte[]B)
        {
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
