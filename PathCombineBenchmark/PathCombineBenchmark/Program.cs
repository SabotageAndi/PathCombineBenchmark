using BenchmarkDotNet.Running;

namespace PathCombineBenchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PathCombineBenchmark>();
            //var summary = BenchmarkRunner.Run<DirectoryListingBenchmark>();
        }
    }
}