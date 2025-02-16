| Method                             | Mean       | Error    | StdDev   | Median     | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------------------------- |-----------:|---------:|---------:|-----------:|------:|--------:|-------:|----------:|------------:|
| AsVector4                          |   268.6 ns |  5.20 ns |  4.61 ns |   268.2 ns |  1.00 |    0.02 |      - |         - |          NA |
| CloneOfAsVector4AggressiveInlining |   268.7 ns |  3.03 ns |  2.69 ns |   268.7 ns |  1.00 |    0.02 |      - |         - |          NA |
| CloneOfAsVector4NoInlining         | 1,563.5 ns | 21.42 ns | 20.03 ns | 1,558.9 ns |  5.82 |    0.12 |      - |         - |          NA |
| CloneOfAsVector4NoAttribute        |   277.9 ns |  3.82 ns |  3.39 ns |   277.7 ns |  1.03 |    0.02 |      - |         - |          NA |
| MemoryMarshalReadWrite             |   646.0 ns |  6.57 ns |  5.49 ns |   646.1 ns |  2.41 |    0.04 | 0.0019 |      40 B |          NA |
| MemoryMarshalReadWriteStackAlloc   |   740.6 ns |  8.32 ns |  7.78 ns |   741.1 ns |  2.76 |    0.05 |      - |         - |          NA |
| CopyFields                         |   379.3 ns |  5.46 ns |  5.11 ns |   378.9 ns |  1.41 |    0.03 |      - |         - |          NA |
| UnsafeBitCast                      |   269.3 ns |  5.08 ns |  4.99 ns |   267.4 ns |  1.00 |    0.02 |      - |         - |          NA |
| UnsafeReadUnaligned                |   279.7 ns |  5.58 ns | 13.04 ns |   277.1 ns |  1.04 |    0.05 |      - |         - |          NA |
| UnsafeReadUnalignedVoidPtr         |   278.4 ns |  5.02 ns |  4.45 ns |   278.1 ns |  1.04 |    0.02 |      - |         - |          NA |
| UnsafeRead                         |   281.6 ns |  5.49 ns | 12.72 ns |   276.6 ns |  1.05 |    0.05 |      - |         - |          NA |