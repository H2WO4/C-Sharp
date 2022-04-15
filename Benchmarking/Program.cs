using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmarking;

public static class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmark>();
    }
}

public enum Test
{
    Flag1 = 1 << 0,
    Flag2 = 1 << 1,
    Flag3 = 1 << 2,
}

public class Benchmark
{
    
}