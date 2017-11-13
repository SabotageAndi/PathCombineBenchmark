using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace PathCombineBenchmark
{
    public class PathCombineBenchmark
    {
        [Benchmark()]
        public string CombineWith2Parameters()
        {
            return Path.Combine("C:", "Temp");
        }

        [Benchmark()]
        public string CombineWith3Parameters()
        {
            return Path.Combine("C:", "Temp", "Folder");
        }

        [Benchmark()]
        public string CombineWith4Parameters()
        {
            return Path.Combine("C:", "Temp", "Folder", "Subfolder");
        }

        [Benchmark()]
        public string CombineWith5Parameters()
        {
            return Path.Combine("C:", "Temp", "Folder", "Subfolder", "Subsubfolder");
        }
    }
}
