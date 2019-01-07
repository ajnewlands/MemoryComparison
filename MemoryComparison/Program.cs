using System;
using System.Diagnostics;

namespace MemoryComparison
{
    class Program
    {
        static long RunTest(IComparison implementation, byte[]A, byte[] B, uint iterations)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for(uint i = 0; i < iterations; i++)
            {
                var b = implementation.Compare(A, B);
                if(!b)
                {
                    Console.WriteLine($"Failure in {implementation.GetType()}");
                    break;
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"{implementation.GetType()} took {(stopwatch.ElapsedTicks / (Decimal)Stopwatch.Frequency).ToString("F")} seconds");

            return stopwatch.ElapsedTicks;
        }

        static void Main(string[] args)
        {
            uint iterations = 100000;
            byte[] A = new byte[100000];
            byte[] B = new byte[100000];

            RunTest(new ForInt64Comparison(), A, B, iterations);
            RunTest(new ForLoopComparison(), A, B, iterations);
            RunTest(new LinqComparison(), A, B, iterations);
            RunTest(new MemcmpComparison(), A, B, iterations);
            RunTest(new UnsafeForloopComparison(), A, B, iterations);


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
