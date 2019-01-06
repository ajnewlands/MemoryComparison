using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryComparison
{
    class UnsafeForloopComparison: IComparison
    {
        public unsafe bool Compare(byte[]A, byte[]B)
        {
            fixed(byte* pA = A, pB = B)
            {
                for (var i = 0; i < A.Length; i++)
                {
                    if (*pA+i != *pB+i)
                        return false;
                }
                return true;
            }
        }
    }
}
