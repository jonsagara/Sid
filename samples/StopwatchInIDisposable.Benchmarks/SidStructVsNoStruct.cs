//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Jobs;

//namespace StopwatchInIDisposable.Benchmarks;

//[SimpleJob(RuntimeMoniker.Net70)]
//[MemoryDiagnoser]
//public class SidStructVsNoStruct
//{
//    /*
//     * Results:
//     * 
//     * All performed equally well.
//     * 
//     * Struct with no Stopwatch had the fewest allocations.
//     * 
//     * Winner: SidStructNoStopwatch
//     * 

//BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.900)
//Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
//.NET SDK=7.0.100
//  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
//  .NET 7.0 : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

//Job=.NET 7.0  Runtime=.NET 7.0

//|               Method |     Mean |   Error |  StdDev | Ratio | Allocated | Alloc Ratio |
//|--------------------- |---------:|--------:|--------:|------:|----------:|------------:|
//|                  Sid | 108.6 ms | 0.75 ms | 0.70 ms |  1.00 |     256 B |        1.00 |
//|       SidNoStopwatch | 108.5 ms | 0.50 ms | 0.47 ms |  1.00 |     240 B |        0.94 |
//|            SidStruct | 108.7 ms | 0.29 ms | 0.27 ms |  1.00 |     232 B |        0.91 |
//| SidStructNoStopwatch | 108.6 ms | 0.62 ms | 0.58 ms |  1.00 |     208 B |        0.81 |
//    */

//    private void DoWork() => Thread.Sleep(100);

//    [Benchmark(Baseline = true)]
//    public void Sid()
//    {
//        using (var sid = new Sid(nameof(Sid)))
//        {
//            DoWork();
//        }
//    }

//    [Benchmark]
//    public void SidNoStopwatch()
//    {
//        using (var sid = new SidNoStopwatch(nameof(SidNoStopwatch)))
//        {
//            DoWork();
//        }
//    }

//    [Benchmark]
//    public void SidStruct()
//    {
//        using (var sid = new SidStruct(nameof(SidStruct)))
//        {
//            DoWork();
//        }
//    }

//    [Benchmark]
//    public void SidStructNoStopwatch()
//    {
//        using (var sid = new SidStructNoStopwatch(nameof(SidStructNoStopwatch)))
//        {
//            DoWork();
//        }
//    }
//}
