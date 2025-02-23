| Method                             | Length  | Mean            | Error         | StdDev        | Ratio | RatioSD | Gen0     | Gen1     | Gen2     | Allocated  | Alloc Ratio |
|----------------------------------- |-------- |----------------:|--------------:|--------------:|------:|--------:|---------:|---------:|---------:|-----------:|------------:|
| Trapz                              | 23      |        26.51 ns |      0.504 ns |      0.472 ns |  1.57 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 23      |        20.56 ns |      0.242 ns |      0.215 ns |  1.22 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 23      |        16.84 ns |      0.258 ns |      0.241 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 23      |        44.35 ns |      0.753 ns |      0.704 ns |  2.63 |    0.05 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 23      |        45.46 ns |      0.429 ns |      0.401 ns |  2.70 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 23      |        12.78 ns |      0.166 ns |      0.155 ns |  0.76 |    0.01 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 135     |       149.89 ns |      1.571 ns |      1.469 ns |  1.52 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 135     |       107.72 ns |      1.366 ns |      1.278 ns |  1.09 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 135     |        98.56 ns |      1.218 ns |      1.140 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 135     |       132.60 ns |      1.285 ns |      1.202 ns |  1.35 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 135     |       138.10 ns |      1.355 ns |      1.201 ns |  1.40 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 135     |        83.82 ns |      1.266 ns |      1.185 ns |  0.85 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 517     |       560.65 ns |      7.452 ns |      6.971 ns |  1.40 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 517     |       406.51 ns |      3.900 ns |      3.648 ns |  1.02 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 517     |       399.32 ns |      6.077 ns |      5.684 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 517     |       417.26 ns |      3.946 ns |      3.081 ns |  1.05 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 517     |       433.38 ns |      6.011 ns |      5.623 ns |  1.09 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 517     |       334.98 ns |      4.978 ns |      4.656 ns |  0.84 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 1023    |     1,089.18 ns |     12.085 ns |     11.305 ns |  1.37 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 1023    |       799.70 ns |      8.620 ns |      8.063 ns |  1.01 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 1023    |       793.06 ns |      9.675 ns |      9.050 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 1023    |       823.67 ns |      7.310 ns |      6.838 ns |  1.04 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 1023    |       855.63 ns |      7.638 ns |      6.771 ns |  1.08 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 1023    |       671.69 ns |      9.048 ns |      8.463 ns |  0.85 |    0.01 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 2051    |     2,183.20 ns |     42.708 ns |     39.949 ns |  1.36 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 2051    |     1,617.33 ns |     19.596 ns |     18.330 ns |  1.01 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 2051    |     1,606.49 ns |     19.619 ns |     18.351 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 2051    |     2,099.59 ns |     39.429 ns |     36.882 ns |  1.31 |    0.03 |   1.9569 |   0.0610 |        - |    32848 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 2051    |     1,374.89 ns |     14.933 ns |     13.968 ns |  0.86 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 2051    |     1,366.98 ns |     21.635 ns |     20.237 ns |  0.85 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 65533   |    68,480.67 ns |    900.331 ns |    842.171 ns |  1.36 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 65533   |    52,425.42 ns |    524.470 ns |    464.929 ns |  1.04 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 65533   |    50,257.35 ns |    720.352 ns |    673.818 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 65533   |   171,051.09 ns |  1,720.827 ns |  1,609.663 ns |  3.40 |    0.05 | 249.7559 | 249.7559 | 249.7559 |  1048632 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 65533   |    34,575.13 ns |    432.510 ns |    404.570 ns |  0.69 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 65533   |    43,781.15 ns |    626.677 ns |    586.194 ns |  0.87 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 1000003 | 1,050,003.49 ns | 10,841.872 ns | 10,141.493 ns |  1.35 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 1000003 |   813,850.48 ns | 12,091.109 ns | 11,310.031 ns |  1.05 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 1000003 |   778,599.90 ns |  6,508.657 ns |  6,088.202 ns |  1.00 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 1000003 | 2,996,837.32 ns | 58,200.335 ns | 54,440.629 ns |  3.85 |    0.07 | 492.1875 | 492.1875 | 492.1875 | 16000234 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 1000003 |   578,494.65 ns |  6,824.247 ns |  6,383.405 ns |  0.74 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 1000003 |   673,279.24 ns |  5,036.580 ns |  4,711.220 ns |  0.86 |    0.01 |        - |        - |        - |          - |          NA |