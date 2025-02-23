| Method                             | Length  | Mean            | Error         | StdDev        | Ratio | RatioSD | Gen0     | Gen1     | Gen2     | Allocated  | Alloc Ratio |
|----------------------------------- |-------- |----------------:|--------------:|--------------:|------:|--------:|---------:|---------:|---------:|-----------:|------------:|
| Trapz                              | 23      |        25.97 ns |      0.537 ns |      0.476 ns |  2.14 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzEnumerable                    | 23      |        82.51 ns |      1.515 ns |      1.343 ns |  6.80 |    0.13 |   0.0038 |        - |        - |       64 B |          NA |
| TrapzPtr                           | 23      |        19.16 ns |      0.408 ns |      0.453 ns |  1.58 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 23      |        16.36 ns |      0.338 ns |      0.651 ns |  1.35 |    0.06 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 23      |        43.05 ns |      0.807 ns |      0.792 ns |  3.55 |    0.07 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 23      |        43.72 ns |      0.495 ns |      0.439 ns |  3.60 |    0.05 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 23      |        12.14 ns |      0.157 ns |      0.139 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 135     |       141.67 ns |      2.346 ns |      2.304 ns |  1.79 |    0.05 |        - |        - |        - |          - |          NA |
| TrapzEnumerable                    | 135     |       349.49 ns |      3.967 ns |      3.516 ns |  4.41 |    0.10 |   0.0038 |        - |        - |       64 B |          NA |
| TrapzPtr                           | 135     |       105.42 ns |      1.916 ns |      2.623 ns |  1.33 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 135     |        92.92 ns |      1.237 ns |      1.097 ns |  1.17 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 135     |       134.12 ns |      2.709 ns |      2.534 ns |  1.69 |    0.05 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 135     |       130.46 ns |      2.556 ns |      2.391 ns |  1.65 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 135     |        79.24 ns |      1.524 ns |      1.693 ns |  1.00 |    0.03 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 517     |       523.10 ns |      8.456 ns |      9.738 ns |  1.62 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzEnumerable                    | 517     |     1,320.02 ns |     26.103 ns |     38.261 ns |  4.10 |    0.13 |   0.0038 |        - |        - |       64 B |          NA |
| TrapzPtr                           | 517     |       389.96 ns |      6.800 ns |     11.361 ns |  1.21 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 517     |       378.15 ns |      4.898 ns |      4.342 ns |  1.17 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 517     |       399.13 ns |      7.675 ns |      9.706 ns |  1.24 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 517     |       424.02 ns |      5.149 ns |      4.565 ns |  1.32 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 517     |       322.38 ns |      5.029 ns |      4.705 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 1023    |     1,023.88 ns |     12.129 ns |      9.470 ns |  1.65 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzEnumerable                    | 1023    |     2,625.32 ns |     29.870 ns |     26.479 ns |  4.24 |    0.06 |   0.0038 |        - |        - |       64 B |          NA |
| TrapzPtr                           | 1023    |       766.22 ns |     10.461 ns |      9.273 ns |  1.24 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 1023    |       753.99 ns |     11.911 ns |     11.141 ns |  1.22 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 1023    |       821.48 ns |     10.710 ns |     10.018 ns |  1.33 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 1023    |       799.57 ns |      9.172 ns |      8.579 ns |  1.29 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 1023    |       619.68 ns |      8.493 ns |      7.529 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 2051    |     2,082.92 ns |     40.353 ns |     44.852 ns |  1.58 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzEnumerable                    | 2051    |     5,314.72 ns |     57.123 ns |     47.700 ns |  4.04 |    0.08 |        - |        - |        - |       64 B |          NA |
| TrapzPtr                           | 2051    |     1,539.53 ns |     20.146 ns |     16.823 ns |  1.17 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 2051    |     1,521.86 ns |     10.945 ns |      9.702 ns |  1.16 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 2051    |     2,130.25 ns |     42.763 ns |    125.418 ns |  1.62 |    0.10 |   1.9569 |   0.0610 |        - |    32848 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 2051    |     1,323.36 ns |     22.498 ns |     21.045 ns |  1.01 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 2051    |     1,317.00 ns |     25.698 ns |     24.038 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 2563    |     2,662.54 ns |     52.161 ns |     87.149 ns |  1.67 |    0.06 |        - |        - |        - |          - |          NA |
| TrapzEnumerable                    | 2563    |     6,644.02 ns |    113.573 ns |    106.236 ns |  4.18 |    0.07 |        - |        - |        - |       64 B |          NA |
| TrapzPtr                           | 2563    |     2,013.37 ns |     39.789 ns |     51.737 ns |  1.27 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 2563    |     1,880.93 ns |     20.998 ns |     17.535 ns |  1.18 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 2563    |     2,575.15 ns |     50.862 ns |    120.880 ns |  1.62 |    0.08 |   2.4452 |   0.0916 |        - |    41040 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 2563    |     1,569.04 ns |     16.250 ns |     15.200 ns |  0.99 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 2563    |     1,591.12 ns |     14.841 ns |     13.883 ns |  1.00 |    0.01 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 65533   |    63,815.49 ns |    687.432 ns |    643.024 ns |  1.52 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzEnumerable                    | 65533   |   164,213.02 ns |    854.608 ns |    667.222 ns |  3.92 |    0.06 |        - |        - |        - |       64 B |          NA |
| TrapzPtr                           | 65533   |    50,368.55 ns |    976.841 ns |  1,431.841 ns |  1.20 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 65533   |    47,896.21 ns |    715.811 ns |    669.570 ns |  1.14 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 65533   |   178,107.78 ns |  3,391.415 ns |  3,006.401 ns |  4.25 |    0.10 | 249.7559 | 249.7559 | 249.7559 |  1048632 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 65533   |    34,275.66 ns |    668.241 ns |    686.235 ns |  0.82 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 65533   |    41,929.38 ns |    773.865 ns |    686.011 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 1000003 | 1,020,064.76 ns | 20,274.312 ns | 38,080.076 ns |  1.57 |    0.08 |        - |        - |        - |        1 B |          NA |
| TrapzEnumerable                    | 1000003 | 2,539,689.84 ns | 26,284.243 ns | 21,948.533 ns |  3.92 |    0.14 |        - |        - |        - |       66 B |          NA |
| TrapzPtr                           | 1000003 |   770,674.57 ns | 13,802.911 ns | 11,526.055 ns |  1.19 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 1000003 |   763,377.96 ns | 12,463.667 ns | 11,658.522 ns |  1.18 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 1000003 | 3,062,409.66 ns | 49,239.987 ns | 46,059.115 ns |  4.72 |    0.17 | 492.1875 | 492.1875 | 492.1875 | 16000235 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 1000003 |   583,374.29 ns | 11,583.273 ns | 15,061.528 ns |  0.90 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 1000003 |   649,165.39 ns | 12,786.619 ns | 22,728.205 ns |  1.00 |    0.05 |        - |        - |        - |          - |          NA |