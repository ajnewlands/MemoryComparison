using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MemoryComparison
{
    public class MemoryComparison
    {
        SpanComparison span = new SpanComparison();
        ForInt64Comparison forInt64 = new ForInt64Comparison();
        ForLoopComparison forLoop = new ForLoopComparison();
        LinqComparison linq = new LinqComparison();
        MemcmpComparison memcmp = new MemcmpComparison();
        UnsafeForloopComparison unsafeforLoop = new UnsafeForloopComparison();

        byte[] A;
        byte[] B;

        [Params(1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            A = new byte[N];
            B = new byte[N];
        }

        [Benchmark]
        public void Span() => span.Compare(A, B);

        [Benchmark]
        public void Memcmp() => memcmp.Compare(A, B);

        [Benchmark]
        public void ForInt64() => forInt64.Compare(A, B);

        [Benchmark]
        public void ForLoop() => forLoop.Compare(A, B);

        [Benchmark]
        public void Linq() => linq.Compare(A, B);

        [Benchmark]
        public void UnsafeForLoop() => unsafeforLoop.Compare(A, B);
           
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MemoryComparison>();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
