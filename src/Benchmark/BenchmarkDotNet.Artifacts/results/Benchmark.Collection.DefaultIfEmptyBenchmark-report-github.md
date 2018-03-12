``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648436 Hz, Resolution=377.5813 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2633.0
  Job-YODCMV : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2633.0

Toolchain=CsProjnet46  LaunchCount=1  TargetCount=3  
WarmupCount=3  

```
|              Method | EnumerateAfterwards | InputLength |        Mean |       Error |     StdDev |  Gen 0 | Allocated |
|-------------------- |-------------------- |------------ |------------:|------------:|-----------:|-------:|----------:|
|      **Array_FastLinq** |               **False** |           **0** |  **10.0716 ns** |   **2.2577 ns** |  **0.1276 ns** | **0.0076** |      **32 B** |
|       Array_Optimal |               False |           0 |   0.7505 ns |   0.9042 ns |  0.0511 ns |      - |       0 B |
|        Array_System |               False |           0 |  15.7030 ns |   1.8470 ns |  0.1044 ns | 0.0152 |      64 B |
| Collection_FastLinq |               False |           0 |   9.6022 ns |   2.1754 ns |  0.1229 ns | 0.0076 |      32 B |
|  Collection_Optimal |               False |           0 |   1.4970 ns |   0.5323 ns |  0.0301 ns |      - |       0 B |
|   Collection_System |               False |           0 |  15.6824 ns |   3.3535 ns |  0.1895 ns | 0.0152 |      64 B |
|  Enumerable_Optimal |               False |           0 |   0.4469 ns |   0.1647 ns |  0.0093 ns |      - |       0 B |
|   Enumerable_System |               False |           0 |  15.9216 ns |   7.2398 ns |  0.4091 ns | 0.0152 |      64 B |
|      IList_FastLinq |               False |           0 |  12.0503 ns |   2.1719 ns |  0.1227 ns | 0.0076 |      32 B |
|       IList_Optimal |               False |           0 |   4.0991 ns |   1.6412 ns |  0.0927 ns |      - |       0 B |
|        IList_System |               False |           0 |  15.5305 ns |   4.5177 ns |  0.2553 ns | 0.0152 |      64 B |
|       List_FastLinq |               False |           0 |  10.1026 ns |   2.4141 ns |  0.1364 ns | 0.0076 |      32 B |
|        List_Optimal |               False |           0 |   1.5812 ns |   0.6648 ns |  0.0376 ns |      - |       0 B |
|         List_System |               False |           0 |  15.7542 ns |   6.0282 ns |  0.3406 ns | 0.0152 |      64 B |
|      **Array_FastLinq** |               **False** |          **10** |   **5.2499 ns** |   **0.4600 ns** |  **0.0260 ns** |      **-** |       **0 B** |
|       Array_Optimal |               False |          10 |   1.2595 ns |   0.6671 ns |  0.0377 ns |      - |       0 B |
|        Array_System |               False |          10 |  15.8768 ns |   1.8456 ns |  0.1043 ns | 0.0152 |      64 B |
| Collection_FastLinq |               False |          10 |   5.1858 ns |   1.9357 ns |  0.1094 ns |      - |       0 B |
|  Collection_Optimal |               False |          10 |   1.4510 ns |   0.5258 ns |  0.0297 ns |      - |       0 B |
|   Collection_System |               False |          10 |  15.7206 ns |   4.4687 ns |  0.2525 ns | 0.0152 |      64 B |
|  Enumerable_Optimal |               False |          10 |   0.4294 ns |   0.9907 ns |  0.0560 ns |      - |       0 B |
|   Enumerable_System |               False |          10 |  15.4507 ns |   3.2665 ns |  0.1846 ns | 0.0152 |      64 B |
|      IList_FastLinq |               False |          10 |   7.3951 ns |   3.1963 ns |  0.1806 ns |      - |       0 B |
|       IList_Optimal |               False |          10 |   4.0448 ns |   1.5827 ns |  0.0894 ns |      - |       0 B |
|        IList_System |               False |          10 |  15.8505 ns |   5.7145 ns |  0.3229 ns | 0.0152 |      64 B |
|       List_FastLinq |               False |          10 |   5.3310 ns |   0.5958 ns |  0.0337 ns |      - |       0 B |
|        List_Optimal |               False |          10 |   1.7300 ns |   0.6376 ns |  0.0360 ns |      - |       0 B |
|         List_System |               False |          10 |  15.7875 ns |   5.0994 ns |  0.2881 ns | 0.0152 |      64 B |
|      **Array_FastLinq** |                **True** |           **0** |  **14.9892 ns** |   **2.4037 ns** |  **0.1358 ns** | **0.0076** |      **32 B** |
|       Array_Optimal |                True |           0 |   1.5212 ns |   1.2919 ns |  0.0730 ns |      - |       0 B |
|        Array_System |                True |           0 |  63.2057 ns |  14.4456 ns |  0.8162 ns | 0.0151 |      64 B |
| Collection_FastLinq |                True |           0 |  32.7224 ns |  21.8839 ns |  1.2365 ns | 0.0152 |      64 B |
|  Collection_Optimal |                True |           0 |  24.5288 ns |   0.4874 ns |  0.0275 ns | 0.0076 |      32 B |
|   Collection_System |                True |           0 |  66.8878 ns |  14.7536 ns |  0.8336 ns | 0.0247 |     104 B |
|  Enumerable_Optimal |                True |           0 |  22.4690 ns |   6.4192 ns |  0.3627 ns | 0.0114 |      48 B |
|   Enumerable_System |                True |           0 |  67.0448 ns |  15.6844 ns |  0.8862 ns | 0.0266 |     112 B |
|      IList_FastLinq |                True |           0 |  18.1062 ns |   4.0023 ns |  0.2261 ns | 0.0076 |      32 B |
|       IList_Optimal |                True |           0 |  10.4556 ns |   4.4081 ns |  0.2491 ns |      - |       0 B |
|        IList_System |                True |           0 |  70.1294 ns |   5.5984 ns |  0.3163 ns | 0.0247 |     104 B |
|       List_FastLinq |                True |           0 |  16.1853 ns |   2.4180 ns |  0.1366 ns | 0.0076 |      32 B |
|        List_Optimal |                True |           0 |   1.8730 ns |   0.4719 ns |  0.0267 ns |      - |       0 B |
|         List_System |                True |           0 |  69.8305 ns |  18.7388 ns |  1.0588 ns | 0.0247 |     104 B |
|      **Array_FastLinq** |                **True** |          **10** |  **54.2527 ns** |  **23.4803 ns** |  **1.3267 ns** |      **-** |       **0 B** |
|       Array_Optimal |                True |          10 |  10.1661 ns |   2.7609 ns |  0.1560 ns |      - |       0 B |
|        Array_System |                True |          10 | 220.7056 ns |  84.1461 ns |  4.7544 ns | 0.0226 |      96 B |
| Collection_FastLinq |                True |          10 | 153.4860 ns |  63.6951 ns |  3.5989 ns | 0.0093 |      40 B |
|  Collection_Optimal |                True |          10 | 149.6546 ns |  40.0796 ns |  2.2646 ns | 0.0093 |      40 B |
|   Collection_System |                True |          10 | 291.3639 ns | 517.4323 ns | 29.2359 ns | 0.0243 |     104 B |
|  Enumerable_Optimal |                True |          10 |  87.4859 ns |  30.4450 ns |  1.7202 ns | 0.0113 |      48 B |
|   Enumerable_System |                True |          10 | 229.3246 ns |   9.6407 ns |  0.5447 ns | 0.0265 |     112 B |
|      IList_FastLinq |                True |          10 |  75.2214 ns |  21.5583 ns |  1.2181 ns |      - |       0 B |
|       IList_Optimal |                True |          10 |  75.9946 ns |   8.9013 ns |  0.5029 ns |      - |       0 B |
|        IList_System |                True |          10 | 252.6041 ns |  90.1153 ns |  5.0917 ns | 0.0243 |     104 B |
|       List_FastLinq |                True |          10 |  50.3056 ns |  10.2477 ns |  0.5790 ns |      - |       0 B |
|        List_Optimal |                True |          10 |  13.8147 ns |   1.4624 ns |  0.0826 ns |      - |       0 B |
|         List_System |                True |          10 | 246.8813 ns |  83.2203 ns |  4.7021 ns | 0.0243 |     104 B |