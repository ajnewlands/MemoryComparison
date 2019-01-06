using System;
using System.Runtime.InteropServices;

namespace MemoryComparison
{
    class MemcmpComparison: IComparison
    {
        public bool Compare(byte[]A, byte[]B)
        {
            if (A.Length != B.Length)
                return false;
            if (memcmp(A, B, A.Length) == 0)
                return true;
            return false;
        }

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, int count);
    }
}
