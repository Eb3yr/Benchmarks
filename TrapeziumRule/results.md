| Method                             | Length  | Mean            | Error         | StdDev        | Ratio | RatioSD | Gen0     | Gen1     | Gen2     | Allocated  | Alloc Ratio |
|----------------------------------- |-------- |----------------:|--------------:|--------------:|------:|--------:|---------:|---------:|---------:|-----------:|------------:|
| Trapz                              | 23      |        26.45 ns |      0.270 ns |      0.239 ns |  2.03 |    0.04 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 23      |        20.13 ns |      0.202 ns |      0.179 ns |  1.55 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 23      |        16.79 ns |      0.302 ns |      0.267 ns |  1.29 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 23      |        44.39 ns |      0.482 ns |      0.451 ns |  3.41 |    0.08 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 23      |        45.89 ns |      0.866 ns |      0.851 ns |  3.53 |    0.09 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 23      |        13.01 ns |      0.276 ns |      0.271 ns |  1.00 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 23      |        12.97 ns |      0.272 ns |      0.242 ns |  1.00 |    0.03 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 135     |       148.62 ns |      2.444 ns |      2.401 ns |  1.89 |    0.05 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 135     |       105.02 ns |      1.169 ns |      1.036 ns |  1.34 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 135     |        93.29 ns |      1.377 ns |      1.586 ns |  1.19 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 135     |       132.77 ns |      2.669 ns |      2.497 ns |  1.69 |    0.05 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 135     |       131.21 ns |      2.250 ns |      2.311 ns |  1.67 |    0.05 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 135     |        78.62 ns |      1.541 ns |      1.893 ns |  1.00 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 135     |        77.07 ns |      1.203 ns |      1.004 ns |  0.98 |    0.03 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 517     |       523.86 ns |      8.248 ns |      9.819 ns |  1.55 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 517     |       381.13 ns |      5.623 ns |      5.260 ns |  1.13 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 517     |       376.36 ns |      4.123 ns |      3.857 ns |  1.12 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 517     |       398.64 ns |      7.160 ns |      6.697 ns |  1.18 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 517     |       422.38 ns |      6.542 ns |      6.119 ns |  1.25 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 517     |       337.05 ns |      3.845 ns |      3.596 ns |  1.00 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 517     |       329.50 ns |      4.392 ns |      4.108 ns |  0.98 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 1023    |     1,087.84 ns |     20.829 ns |     18.464 ns |  1.63 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 1023    |       792.52 ns |     11.548 ns |     10.802 ns |  1.19 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 1023    |       792.47 ns |     11.950 ns |     11.178 ns |  1.19 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 1023    |       853.47 ns |      7.903 ns |      7.392 ns |  1.28 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitivesSlidingWindow | 1023    |       857.15 ns |     11.204 ns |     10.480 ns |  1.29 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 1023    |       665.95 ns |      8.421 ns |      7.877 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 1023    |       656.27 ns |     11.193 ns |     10.470 ns |  0.99 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 2051    |     2,200.33 ns |     37.666 ns |     35.233 ns |  1.62 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 2051    |     1,613.88 ns |     14.617 ns |     13.672 ns |  1.19 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 2051    |     1,596.36 ns |     17.923 ns |     16.766 ns |  1.18 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 2051    |     2,089.49 ns |     37.204 ns |     32.980 ns |  1.54 |    0.03 |   1.9569 |   0.0610 |        - |    32848 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 2051    |     1,376.85 ns |     14.619 ns |     13.675 ns |  1.02 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 2051    |     1,355.65 ns |     19.219 ns |     17.977 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 2051    |     1,332.66 ns |     16.492 ns |     15.427 ns |  0.98 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 2563    |     2,750.02 ns |     33.940 ns |     31.747 ns |  1.62 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 2563    |     2,041.69 ns |     33.477 ns |     31.314 ns |  1.20 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 2563    |     1,992.51 ns |     38.621 ns |     42.927 ns |  1.17 |    0.03 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 2563    |     2,578.55 ns |     33.451 ns |     31.290 ns |  1.52 |    0.03 |   2.4452 |   0.0916 |        - |    41040 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 2563    |     1,618.50 ns |     18.358 ns |     17.172 ns |  0.95 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 2563    |     1,700.36 ns |     23.674 ns |     22.145 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 2563    |     1,622.72 ns |     17.791 ns |     16.642 ns |  0.95 |    0.02 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 65533   |    68,717.58 ns |    741.852 ns |    693.929 ns |  1.57 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtr                           | 65533   |    52,499.29 ns |    377.290 ns |    352.917 ns |  1.20 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 65533   |    50,586.80 ns |    771.237 ns |    683.682 ns |  1.16 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 65533   |   173,059.19 ns |  2,388.702 ns |  2,234.394 ns |  3.95 |    0.07 | 249.7559 | 249.7559 | 249.7559 |  1048632 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 65533   |    34,860.99 ns |    449.007 ns |    420.001 ns |  0.80 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 65533   |    43,781.22 ns |    593.924 ns |    555.556 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 65533   |    34,554.03 ns |    355.012 ns |    332.079 ns |  0.79 |    0.01 |        - |        - |        - |          - |          NA |
|                                    |         |                 |               |               |       |         |          |          |          |            |             |
| Trapz                              | 1000003 | 1,043,857.42 ns | 11,884.377 ns | 11,116.654 ns |  1.56 |    0.02 |        - |        - |        - |        1 B |          NA |
| TrapzPtr                           | 1000003 |   805,656.91 ns |  9,726.342 ns |  9,098.026 ns |  1.21 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzPtrUnrolled                   | 1000003 |   773,335.35 ns |  8,199.471 ns |  7,669.791 ns |  1.16 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzTensorPrimitives              | 1000003 | 3,103,726.14 ns | 39,362.955 ns | 34,894.235 ns |  4.65 |    0.07 | 492.1875 | 492.1875 | 492.1875 | 16000235 B |          NA |
| TrapzTensorPrimitivesSlidingWindow | 1000003 |   570,672.19 ns |  7,516.625 ns |  7,031.055 ns |  0.85 |    0.01 |        - |        - |        - |          - |          NA |
| TrapzVectors                       | 1000003 |   668,239.21 ns |  7,825.380 ns |  7,319.866 ns |  1.00 |    0.02 |        - |        - |        - |          - |          NA |
| TrapzOptimal                       | 1000003 |   606,769.53 ns | 11,479.981 ns | 10,738.382 ns |  0.91 |    0.02 |        - |        - |        - |          - |          NA |