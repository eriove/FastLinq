``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10.0.17134
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3101.0
  Job-YODCMV : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3101.0

Toolchain=CsProjnet46  LaunchCount=1  TargetCount=3  
WarmupCount=3  

```
|             Method | EnumerateAfterwards | SizeOfInput |          Mean |         Error |      StdDev |  Gen 0 | Allocated |
|------------------- |-------------------- |------------ |--------------:|--------------:|------------:|-------:|----------:|
|    **Array_FastLinq1** |               **False** |           **0** |      **8.973 ns** |     **1.9162 ns** |   **0.1083 ns** | **0.0057** |      **24 B** |
|    Array_FastLinq2 |               False |           0 |      8.335 ns |     1.7730 ns |   0.1002 ns | 0.0057 |      24 B |
|      Array_Optimal |               False |           0 |      5.504 ns |     4.3559 ns |   0.2461 ns | 0.0057 |      24 B |
|       Array_System |               False |           0 |     62.318 ns |    17.2596 ns |   0.9752 ns | 0.0132 |      56 B |
| Collection_Optimal |               False |           0 |     18.256 ns |    16.3618 ns |   0.9245 ns | 0.0057 |      24 B |
|  Collection_System |               False |           0 |    174.270 ns |    18.5155 ns |   1.0462 ns | 0.0131 |      56 B |
|  Enumerable_System |               False |           0 |    155.207 ns |    58.5193 ns |   3.3064 ns | 0.0131 |      56 B |
|    IList_FastLinq1 |               False |           0 |      8.492 ns |     2.1961 ns |   0.1241 ns | 0.0057 |      24 B |
|    IList_FastLinq2 |               False |           0 |      8.274 ns |     2.3004 ns |   0.1300 ns | 0.0057 |      24 B |
|      IList_Optimal |               False |           0 |      6.877 ns |     4.1854 ns |   0.2365 ns | 0.0057 |      24 B |
|       IList_System |               False |           0 |    183.776 ns |   148.2629 ns |   8.3771 ns | 0.0131 |      56 B |
|     List_FastLinq1 |               False |           0 |      8.461 ns |     1.8436 ns |   0.1042 ns | 0.0057 |      24 B |
|     List_FastLinq2 |               False |           0 |      8.720 ns |     9.8238 ns |   0.5551 ns | 0.0057 |      24 B |
|       List_Optimal |               False |           0 |      4.888 ns |     3.0814 ns |   0.1741 ns | 0.0057 |      24 B |
|        List_System |               False |           0 |    191.358 ns |    18.8719 ns |   1.0663 ns | 0.0131 |      56 B |
|    **Array_FastLinq1** |               **False** |          **10** |      **9.037 ns** |     **5.5606 ns** |   **0.3142 ns** | **0.0057** |      **24 B** |
|    Array_FastLinq2 |               False |          10 |      8.276 ns |     1.1365 ns |   0.0642 ns | 0.0057 |      24 B |
|      Array_Optimal |               False |          10 |     47.352 ns |    25.8305 ns |   1.4595 ns | 0.0533 |     224 B |
|       Array_System |               False |          10 |     65.526 ns |    11.2568 ns |   0.6360 ns | 0.0132 |      56 B |
| Collection_Optimal |               False |          10 |    147.392 ns |    18.8206 ns |   1.0634 ns | 0.0818 |     344 B |
|  Collection_System |               False |          10 |    173.321 ns |    39.8283 ns |   2.2504 ns | 0.0131 |      56 B |
|  Enumerable_System |               False |          10 |    156.875 ns |    42.3906 ns |   2.3951 ns | 0.0131 |      56 B |
|    IList_FastLinq1 |               False |          10 |      8.475 ns |     2.1507 ns |   0.1215 ns | 0.0057 |      24 B |
|    IList_FastLinq2 |               False |          10 |      8.247 ns |     0.7171 ns |   0.0405 ns | 0.0057 |      24 B |
|      IList_Optimal |               False |          10 |     61.148 ns |    18.3379 ns |   1.0361 ns | 0.0533 |     224 B |
|       IList_System |               False |          10 |    177.576 ns |     6.3242 ns |   0.3573 ns | 0.0131 |      56 B |
|     List_FastLinq1 |               False |          10 |      8.427 ns |     7.0479 ns |   0.3982 ns | 0.0057 |      24 B |
|     List_FastLinq2 |               False |          10 |      8.322 ns |     1.4921 ns |   0.0843 ns | 0.0057 |      24 B |
|       List_Optimal |               False |          10 |     49.346 ns |    10.5870 ns |   0.5982 ns | 0.0533 |     224 B |
|        List_System |               False |          10 |    176.228 ns |    58.9942 ns |   3.3333 ns | 0.0131 |      56 B |
|    **Array_FastLinq1** |               **False** |         **100** |      **8.168 ns** |     **2.5945 ns** |   **0.1466 ns** | **0.0057** |      **24 B** |
|    Array_FastLinq2 |               False |         100 |      8.261 ns |     4.6731 ns |   0.2640 ns | 0.0057 |      24 B |
|      Array_Optimal |               False |         100 |    432.677 ns |   221.7715 ns |  12.5305 ns | 0.4821 |    2024 B |
|       Array_System |               False |         100 |     63.809 ns |    18.3153 ns |   1.0348 ns | 0.0132 |      56 B |
| Collection_Optimal |               False |         100 |  1,137.502 ns |    38.8216 ns |   2.1935 ns | 0.7668 |    3224 B |
|  Collection_System |               False |         100 |    176.043 ns |    82.9582 ns |   4.6873 ns | 0.0131 |      56 B |
|  Enumerable_System |               False |         100 |    158.149 ns |   114.6056 ns |   6.4754 ns | 0.0131 |      56 B |
|    IList_FastLinq1 |               False |         100 |      8.291 ns |     0.4311 ns |   0.0244 ns | 0.0057 |      24 B |
|    IList_FastLinq2 |               False |         100 |      8.418 ns |     2.1982 ns |   0.1242 ns | 0.0057 |      24 B |
|      IList_Optimal |               False |         100 |    561.138 ns |   244.8334 ns |  13.8335 ns | 0.4816 |    2024 B |
|       IList_System |               False |         100 |    192.597 ns |   313.4177 ns |  17.7087 ns | 0.0131 |      56 B |
|     List_FastLinq1 |               False |         100 |      8.297 ns |     2.1503 ns |   0.1215 ns | 0.0057 |      24 B |
|     List_FastLinq2 |               False |         100 |      8.508 ns |     4.6874 ns |   0.2648 ns | 0.0057 |      24 B |
|       List_Optimal |               False |         100 |    443.446 ns |   133.0388 ns |   7.5169 ns | 0.4821 |    2024 B |
|        List_System |               False |         100 |    179.031 ns |   161.5898 ns |   9.1301 ns | 0.0131 |      56 B |
|    **Array_FastLinq1** |                **True** |           **0** |     **42.276 ns** |    **23.6955 ns** |   **1.3388 ns** | **0.0172** |      **72 B** |
|    Array_FastLinq2 |                True |           0 |     40.652 ns |     2.6988 ns |   0.1525 ns | 0.0172 |      72 B |
|      Array_Optimal |                True |           0 |      5.226 ns |     0.7869 ns |   0.0445 ns | 0.0057 |      24 B |
|       Array_System |                True |           0 |    119.537 ns |    42.1598 ns |   2.3821 ns | 0.0207 |      88 B |
| Collection_Optimal |                True |           0 |     17.001 ns |     1.6390 ns |   0.0926 ns | 0.0057 |      24 B |
|  Collection_System |                True |           0 |    228.099 ns |   106.2825 ns |   6.0052 ns | 0.0226 |      96 B |
|  Enumerable_System |                True |           0 |    205.970 ns |    18.3739 ns |   1.0382 ns | 0.0246 |     104 B |
|    IList_FastLinq1 |                True |           0 |     42.034 ns |    12.7822 ns |   0.7222 ns | 0.0172 |      72 B |
|    IList_FastLinq2 |                True |           0 |     42.879 ns |     4.6619 ns |   0.2634 ns | 0.0172 |      72 B |
|      IList_Optimal |                True |           0 |      7.771 ns |    14.2329 ns |   0.8042 ns | 0.0057 |      24 B |
|       IList_System |                True |           0 |    229.667 ns |    72.9045 ns |   4.1192 ns | 0.0226 |      96 B |
|     List_FastLinq1 |                True |           0 |     43.369 ns |    55.1400 ns |   3.1155 ns | 0.0172 |      72 B |
|     List_FastLinq2 |                True |           0 |     40.815 ns |    12.6755 ns |   0.7162 ns | 0.0172 |      72 B |
|       List_Optimal |                True |           0 |      4.899 ns |     2.8816 ns |   0.1628 ns | 0.0057 |      24 B |
|        List_System |                True |           0 |    235.032 ns |    53.4636 ns |   3.0208 ns | 0.0226 |      96 B |
|    **Array_FastLinq1** |                **True** |          **10** |  **1,063.390 ns** |   **245.5855 ns** |  **13.8760 ns** | **0.0725** |     **312 B** |
|    Array_FastLinq2 |                True |          10 |    459.831 ns |   117.5888 ns |   6.6440 ns | 0.1311 |     552 B |
|      Array_Optimal |                True |          10 |     54.751 ns |    36.8685 ns |   2.0831 ns | 0.0533 |     224 B |
|       Array_System |                True |          10 |  1,185.074 ns |   243.0475 ns |  13.7326 ns | 0.0763 |     328 B |
| Collection_Optimal |                True |          10 |    152.018 ns |    21.9746 ns |   1.2416 ns | 0.0818 |     344 B |
|  Collection_System |                True |          10 |    577.623 ns |   183.4450 ns |  10.3650 ns | 0.0801 |     336 B |
|  Enumerable_System |                True |          10 |    518.932 ns |   150.8249 ns |   8.5219 ns | 0.0811 |     344 B |
|    IList_FastLinq1 |                True |          10 |    380.683 ns |   130.3404 ns |   7.3645 ns | 0.0739 |     312 B |
|    IList_FastLinq2 |                True |          10 |    470.625 ns |    53.1024 ns |   3.0004 ns | 0.1307 |     552 B |
|      IList_Optimal |                True |          10 |     70.098 ns |    18.6882 ns |   1.0559 ns | 0.0533 |     224 B |
|       IList_System |                True |          10 |    578.932 ns |   420.3889 ns |  23.7528 ns | 0.0801 |     336 B |
|     List_FastLinq1 |                True |          10 |    316.400 ns |    68.5384 ns |   3.8725 ns | 0.0739 |     312 B |
|     List_FastLinq2 |                True |          10 |    447.086 ns |    24.4914 ns |   1.3838 ns | 0.1311 |     552 B |
|       List_Optimal |                True |          10 |     58.273 ns |    11.2320 ns |   0.6346 ns | 0.0533 |     224 B |
|        List_System |                True |          10 |    588.647 ns |   521.5895 ns |  29.4708 ns | 0.0801 |     336 B |
|    **Array_FastLinq1** |                **True** |         **100** |  **9,939.759 ns** |   **968.0523 ns** |  **54.6967 ns** | **0.5798** |    **2472 B** |
|    Array_FastLinq2 |                True |         100 |  4,025.618 ns | 1,647.7393 ns |  93.1003 ns | 1.1597 |    4872 B |
|      Array_Optimal |                True |         100 |    477.835 ns |    54.9507 ns |   3.1048 ns | 0.4816 |    2024 B |
|       Array_System |                True |         100 | 10,247.428 ns | 1,985.1937 ns | 112.1671 ns | 0.5798 |    2488 B |
| Collection_Optimal |                True |         100 |  1,248.378 ns | 1,136.0676 ns |  64.1899 ns | 0.7668 |    3224 B |
|  Collection_System |                True |         100 |  3,479.163 ns |   451.7398 ns |  25.5241 ns | 0.5913 |    2496 B |
|  Enumerable_System |                True |         100 |  2,938.318 ns |   496.3734 ns |  28.0460 ns | 0.5951 |    2504 B |
|    IList_FastLinq1 |                True |         100 |  3,377.983 ns | 1,403.2853 ns |  79.2882 ns | 0.5875 |    2472 B |
|    IList_FastLinq2 |                True |         100 |  4,311.544 ns | 1,080.7610 ns |  61.0650 ns | 1.1597 |    4872 B |
|      IList_Optimal |                True |         100 |    637.413 ns |   122.9969 ns |   6.9496 ns | 0.4816 |    2024 B |
|       IList_System |                True |         100 |  3,372.116 ns |   707.3350 ns |  39.9657 ns | 0.5913 |    2496 B |
|     List_FastLinq1 |                True |         100 |  2,772.731 ns |   128.6681 ns |   7.2700 ns | 0.5875 |    2472 B |
|     List_FastLinq2 |                True |         100 |  3,945.572 ns | 1,828.5228 ns | 103.3149 ns | 1.1597 |    4872 B |
|       List_Optimal |                True |         100 |    542.699 ns |   176.0695 ns |   9.9483 ns | 0.4816 |    2024 B |
|        List_System |                True |         100 |  3,258.214 ns |   285.4893 ns |  16.1307 ns | 0.5913 |    2496 B |