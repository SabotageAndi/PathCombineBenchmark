using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using Library;

namespace PathCombineBenchmark
{
    public class PathCombineBenchmark
    {
        [Benchmark()]
        public string CombineWith2Parameters()
        {
            return Logic.PathCombine("C:", "Temp");
        }

        [Benchmark()]
        public string CombineWith3Parameters()
        {
            return Logic.PathCombine("C:", "Temp", "Folder");
        }

        [Benchmark()]
        public string CombineWith4Parameters()
        {
            return Logic.PathCombine("C:", "Temp", "Folder", "Subfolder");
        }

        [Benchmark()]
        public string CombineWith5Parameters()
        {
            return Logic.PathCombine("C:", "Temp", "Folder", "Subfolder", "Subsubfolder");
        }
    }
}
