using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System.Threading.Tasks;

namespace StructPacking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = DefaultConfig.Instance;
            var summaryRead = BenchmarkRunner.Run<Benchmark>(config, args);
            // Use this to select benchmarks from the console:
            // var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
        }
    }
}