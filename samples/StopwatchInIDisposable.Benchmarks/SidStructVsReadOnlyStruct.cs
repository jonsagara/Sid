using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace StopwatchInIDisposable.Benchmarks;

//[SimpleJob(RuntimeMoniker.Net70)]
//[MemoryDiagnoser]
//public class SidStructVsReadOnlyStruct
//{
//    /*
//     * Results:
//     * 
//     * 'struct' vs 'readonly struct'
//     * 
//     * Performance characteristics are identical. May as well make it readonly for safety.
//     * 
//     * 
//BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.900)
//Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
//.NET SDK=7.0.100
//  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
//  .NET 7.0 : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

//Job=.NET 7.0  Runtime=.NET 7.0

//|            Method |     Mean |   Error |  StdDev | Ratio | Allocated | Alloc Ratio |
//|------------------ |---------:|--------:|--------:|------:|----------:|------------:|
//|         SidStruct | 108.4 ms | 0.46 ms | 0.41 ms |  1.00 |     192 B |        1.00 |
//| SidReadOnlyStruct | 108.5 ms | 0.57 ms | 0.54 ms |  1.00 |     192 B |        1.00 |

//    */

//    private void DoWork() => Thread.Sleep(100);

//    [Benchmark(Baseline = true)]
//    public void SidStruct()
//    {
//        using (var sid = new SidStruct("test-timer"))
//        {
//            DoWork();
//        }
//    }

//    [Benchmark]
//    public void SidReadOnlyStruct()
//    {
//        using (var sid = new SidReadOnlyStruct("test-timer"))
//        {
//            DoWork();
//        }
//    }
//}
