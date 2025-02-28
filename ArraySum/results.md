| Method              | Length | Mean           | Error       | StdDev        | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------- |------- |---------------:|------------:|--------------:|------:|--------:|----------:|------------:|
| SumLinq             | 4      |      2.8551 ns |   0.0343 ns |     0.0286 ns |  1.80 |    0.04 |         - |          NA |
| SumFor              | 4      |      1.5862 ns |   0.0422 ns |     0.0374 ns |  1.00 |    0.03 |         - |          NA |
| SumForeach          | 4      |      0.8726 ns |   0.0297 ns |     0.0278 ns |  0.55 |    0.02 |         - |          NA |
| SumPointers         | 4      |      1.4150 ns |   0.0540 ns |     0.0683 ns |  0.89 |    0.05 |         - |          NA |
| SumPointersUnwound  | 4      |      1.1926 ns |   0.0276 ns |     0.0258 ns |  0.75 |    0.02 |         - |          NA |
| SumVector           | 4      |      1.1388 ns |   0.0406 ns |     0.0360 ns |  0.72 |    0.03 |         - |          NA |
| SumTensorPrimitives | 4      |      3.5948 ns |   0.0537 ns |     0.0502 ns |  2.27 |    0.06 |         - |          NA |
|                     |        |                |             |               |       |         |           |             |
| SumLinq             | 16     |     11.3081 ns |   0.0719 ns |     0.0673 ns |  1.60 |    0.02 |         - |          NA |
| SumFor              | 16     |      7.0562 ns |   0.0822 ns |     0.0729 ns |  1.00 |    0.01 |         - |          NA |
| SumForeach          | 16     |      4.9243 ns |   0.1195 ns |     0.1279 ns |  0.70 |    0.02 |         - |          NA |
| SumPointers         | 16     |      5.7036 ns |   0.0712 ns |     0.0595 ns |  0.81 |    0.01 |         - |          NA |
| SumPointersUnwound  | 16     |      5.6389 ns |   0.1114 ns |     0.1094 ns |  0.80 |    0.02 |         - |          NA |
| SumVector           | 16     |      3.5923 ns |   0.0955 ns |     0.1022 ns |  0.51 |    0.01 |         - |          NA |
| SumTensorPrimitives | 16     |      4.3450 ns |   0.1072 ns |     0.1053 ns |  0.62 |    0.02 |         - |          NA |
|                     |        |                |             |               |       |         |           |             |
| SumLinq             | 128    |     92.9390 ns |   1.4419 ns |     1.3487 ns |  1.22 |    0.02 |         - |          NA |
| SumFor              | 128    |     76.1303 ns |   0.6717 ns |     0.5955 ns |  1.00 |    0.01 |         - |          NA |
| SumForeach          | 128    |     69.1318 ns |   0.4425 ns |     0.4139 ns |  0.91 |    0.01 |         - |          NA |
| SumPointers         | 128    |     71.0809 ns |   1.0012 ns |     0.9365 ns |  0.93 |    0.01 |         - |          NA |
| SumPointersUnwound  | 128    |     70.7775 ns |   0.8212 ns |     0.7681 ns |  0.93 |    0.01 |         - |          NA |
| SumVector           | 128    |     19.6999 ns |   0.2019 ns |     0.1889 ns |  0.26 |    0.00 |         - |          NA |
| SumTensorPrimitives | 128    |      8.3178 ns |   0.0793 ns |     0.0703 ns |  0.11 |    0.00 |         - |          NA |
|                     |        |                |             |               |       |         |           |             |
| SumLinq             | 4096   |  6,220.9517 ns | 117.3986 ns |   104.0708 ns |  2.12 |    0.04 |         - |          NA |
| SumFor              | 4096   |  2,937.1941 ns |  40.0254 ns |    37.4398 ns |  1.00 |    0.02 |         - |          NA |
| SumForeach          | 4096   |  2,866.6001 ns |  36.1097 ns |    32.0103 ns |  0.98 |    0.02 |         - |          NA |
| SumPointers         | 4096   |  2,897.0564 ns |  37.6862 ns |    35.2517 ns |  0.99 |    0.02 |         - |          NA |
| SumPointersUnwound  | 4096   |  2,934.8283 ns |  28.5600 ns |    26.7150 ns |  1.00 |    0.02 |         - |          NA |
| SumVector           | 4096   |    554.2923 ns |  11.1130 ns |    12.3521 ns |  0.19 |    0.00 |         - |          NA |
| SumTensorPrimitives | 4096   |    336.8834 ns |   4.6345 ns |     4.3351 ns |  0.11 |    0.00 |         - |          NA |
|                     |        |                |             |               |       |         |           |             |
| SumLinq             | 65536  | 82,172.9325 ns | 648.4709 ns |   606.5801 ns |  1.76 |    0.04 |         - |          NA |
| SumFor              | 65536  | 46,754.8779 ns | 910.5587 ns | 1,048.6007 ns |  1.00 |    0.03 |         - |          NA |
| SumForeach          | 65536  | 46,955.3550 ns | 677.2993 ns |   633.5462 ns |  1.00 |    0.03 |         - |          NA |
| SumPointers         | 65536  | 47,513.7307 ns | 400.3157 ns |   374.4556 ns |  1.02 |    0.02 |         - |          NA |
| SumPointersUnwound  | 65536  | 47,356.7700 ns | 568.6991 ns |   531.9615 ns |  1.01 |    0.02 |         - |          NA |
| SumVector           | 65536  |  8,880.6719 ns | 146.1689 ns |   136.7264 ns |  0.19 |    0.01 |         - |          NA |
| SumTensorPrimitives | 65536  |  5,917.0907 ns |  77.3885 ns |    72.3892 ns |  0.13 |    0.00 |         - |          NA |