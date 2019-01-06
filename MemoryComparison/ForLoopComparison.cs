using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryComparison
{
    public class ForLoopComparison: IComparison
    {
        public bool Compare(byte[] A, byte[]B)
        {
            if (A.Length != B.Length)
                return false;

            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                    return false;
            }
            return true;
        }
    }
}
