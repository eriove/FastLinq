``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648436 Hz, Resolution=377.5813 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2633.0
  Job-YODCMV : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2633.0

Toolchain=CsProjnet46  LaunchCount=1  TargetCount=3  
WarmupCount=3  

```
|            Method | SizeOfInput | ElementToRequest |       Mean |      Error |    StdDev |  Gen 0 | Allocated |
|------------------ |------------ |----------------- |-----------:|-----------:|----------:|-------:|----------:|
|    **Array_FastLinq** |           **0** |                **0** |         **NA** |         **NA** |        **NA** |    **N/A** |       **N/A** |
|     Array_Optimal |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|      Array_System |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
| Collection_System |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
| Enumerable_System |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|    IList_FastLinq |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|     IList_Optimal |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|      IList_System |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|     List_FastLinq |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|      List_Optimal |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|       List_System |           0 |                0 |         NA |         NA |        NA |    N/A |       N/A |
|    **Array_FastLinq** |           **0** |               **10** |         **NA** |         **NA** |        **NA** |    **N/A** |       **N/A** |
|     Array_Optimal |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|      Array_System |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
| Collection_System |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
| Enumerable_System |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|    IList_FastLinq |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|     IList_Optimal |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|      IList_System |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|     List_FastLinq |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|      List_Optimal |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|       List_System |           0 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|    **Array_FastLinq** |           **0** |              **100** |         **NA** |         **NA** |        **NA** |    **N/A** |       **N/A** |
|     Array_Optimal |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      Array_System |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
| Collection_System |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
| Enumerable_System |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|    IList_FastLinq |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|     IList_Optimal |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      IList_System |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|     List_FastLinq |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      List_Optimal |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|       List_System |           0 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|    **Array_FastLinq** |          **10** |                **0** |  **3.2944 ns** |  **0.3564 ns** | **0.0201 ns** |      **-** |       **0 B** |
|     Array_Optimal |          10 |                0 |  0.0118 ns |  0.3615 ns | 0.0204 ns |      - |       0 B |
|      Array_System |          10 |                0 | 26.4505 ns |  2.9885 ns | 0.1689 ns |      - |       0 B |
| Collection_System |          10 |                0 | 31.2954 ns |  2.4819 ns | 0.1402 ns | 0.0095 |      40 B |
| Enumerable_System |          10 |                0 | 26.9855 ns |  4.1030 ns | 0.2318 ns | 0.0114 |      48 B |
|    IList_FastLinq |          10 |                0 |  4.9065 ns |  1.1220 ns | 0.0634 ns |      - |       0 B |
|     IList_Optimal |          10 |                0 |  2.7034 ns |  0.5077 ns | 0.0287 ns |      - |       0 B |
|      IList_System |          10 |                0 |  7.3174 ns |  1.4088 ns | 0.0796 ns |      - |       0 B |
|     List_FastLinq |          10 |                0 |  3.0285 ns |  1.4040 ns | 0.0793 ns |      - |       0 B |
|      List_Optimal |          10 |                0 |  0.9244 ns |  0.1411 ns | 0.0080 ns |      - |       0 B |
|       List_System |          10 |                0 |  6.4562 ns |  7.7658 ns | 0.4388 ns |      - |       0 B |
|    **Array_FastLinq** |          **10** |               **10** |         **NA** |         **NA** |        **NA** |    **N/A** |       **N/A** |
|     Array_Optimal |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|      Array_System |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
| Collection_System |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
| Enumerable_System |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|    IList_FastLinq |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|     IList_Optimal |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|      IList_System |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|     List_FastLinq |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|      List_Optimal |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|       List_System |          10 |               10 |         NA |         NA |        NA |    N/A |       N/A |
|    **Array_FastLinq** |          **10** |              **100** |         **NA** |         **NA** |        **NA** |    **N/A** |       **N/A** |
|     Array_Optimal |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      Array_System |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
| Collection_System |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
| Enumerable_System |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|    IList_FastLinq |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|     IList_Optimal |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      IList_System |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|     List_FastLinq |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      List_Optimal |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|       List_System |          10 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|    **Array_FastLinq** |         **100** |                **0** |  **3.4021 ns** |  **1.1001 ns** | **0.0622 ns** |      **-** |       **0 B** |
|     Array_Optimal |         100 |                0 |  0.0000 ns |  0.0000 ns | 0.0000 ns |      - |       0 B |
|      Array_System |         100 |                0 | 26.2204 ns |  4.6332 ns | 0.2618 ns |      - |       0 B |
| Collection_System |         100 |                0 | 31.3848 ns | 11.1408 ns | 0.6295 ns | 0.0095 |      40 B |
| Enumerable_System |         100 |                0 | 27.2543 ns | 10.2884 ns | 0.5813 ns | 0.0114 |      48 B |
|    IList_FastLinq |         100 |                0 |  4.9154 ns |  1.8627 ns | 0.1052 ns |      - |       0 B |
|     IList_Optimal |         100 |                0 |  2.7095 ns |  1.1141 ns | 0.0629 ns |      - |       0 B |
|      IList_System |         100 |                0 |  7.3454 ns |  3.6709 ns | 0.2074 ns |      - |       0 B |
|     List_FastLinq |         100 |                0 |  3.1795 ns |  0.6295 ns | 0.0356 ns |      - |       0 B |
|      List_Optimal |         100 |                0 |  0.8884 ns |  0.3460 ns | 0.0195 ns |      - |       0 B |
|       List_System |         100 |                0 |  5.5621 ns |  0.3487 ns | 0.0197 ns |      - |       0 B |
|    **Array_FastLinq** |         **100** |               **10** |  **3.4214 ns** |  **0.9154 ns** | **0.0517 ns** |      **-** |       **0 B** |
|     Array_Optimal |         100 |               10 |  0.0049 ns |  0.1509 ns | 0.0085 ns |      - |       0 B |
|      Array_System |         100 |               10 | 26.7411 ns |  1.7738 ns | 0.1002 ns |      - |       0 B |
| Collection_System |         100 |               10 | 98.7018 ns |  7.4392 ns | 0.4203 ns | 0.0094 |      40 B |
| Enumerable_System |         100 |               10 | 71.4222 ns | 17.7444 ns | 1.0026 ns | 0.0113 |      48 B |
|    IList_FastLinq |         100 |               10 |  5.3454 ns |  1.3898 ns | 0.0785 ns |      - |       0 B |
|     IList_Optimal |         100 |               10 |  2.5413 ns |  1.5475 ns | 0.0874 ns |      - |       0 B |
|      IList_System |         100 |               10 |  7.4514 ns |  4.9186 ns | 0.2779 ns |      - |       0 B |
|     List_FastLinq |         100 |               10 |  3.1513 ns |  2.1317 ns | 0.1204 ns |      - |       0 B |
|      List_Optimal |         100 |               10 |  1.0347 ns |  3.0742 ns | 0.1737 ns |      - |       0 B |
|       List_System |         100 |               10 |  5.5033 ns |  0.7899 ns | 0.0446 ns |      - |       0 B |
|    **Array_FastLinq** |         **100** |              **100** |         **NA** |         **NA** |        **NA** |    **N/A** |       **N/A** |
|     Array_Optimal |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      Array_System |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
| Collection_System |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
| Enumerable_System |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|    IList_FastLinq |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|     IList_Optimal |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      IList_System |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|     List_FastLinq |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|      List_Optimal |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |
|       List_System |         100 |              100 |         NA |         NA |        NA |    N/A |       N/A |

Benchmarks with issues:
  ElementAtBenchmark.Array_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.Array_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.Array_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.Collection_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.Enumerable_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.IList_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.IList_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.IList_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.List_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.List_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.List_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=0]
  ElementAtBenchmark.Array_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.Array_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.Array_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.Collection_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.Enumerable_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.IList_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.IList_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.IList_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.List_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.List_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.List_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=10]
  ElementAtBenchmark.Array_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.Array_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.Array_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.Collection_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.Enumerable_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.IList_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.IList_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.IList_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.List_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.List_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.List_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=0, ElementToRequest=100]
  ElementAtBenchmark.Array_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.Array_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.Array_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.Collection_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.Enumerable_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.IList_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.IList_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.IList_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.List_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.List_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.List_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=10]
  ElementAtBenchmark.Array_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.Array_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.Array_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.Collection_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.Enumerable_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.IList_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.IList_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.IList_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.List_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.List_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.List_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=10, ElementToRequest=100]
  ElementAtBenchmark.Array_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.Array_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.Array_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.Collection_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.Enumerable_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.IList_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.IList_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.IList_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.List_FastLinq: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.List_Optimal: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
  ElementAtBenchmark.List_System: Job-YODCMV(Toolchain=CsProjnet46, LaunchCount=1, TargetCount=3, WarmupCount=3) [SizeOfInput=100, ElementToRequest=100]
