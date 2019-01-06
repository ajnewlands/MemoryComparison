using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryComparison
{
    interface IComparison
    {
        bool Compare(byte[] A, byte[] B);
    }
}
