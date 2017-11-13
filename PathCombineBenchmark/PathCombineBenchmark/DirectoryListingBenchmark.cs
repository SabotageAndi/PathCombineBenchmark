using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace PathCombineBenchmark
{
    public class DirectoryListingBenchmark
    {
        [Benchmark]
        public List<string> Subdirectories()
        {
            return Directory.EnumerateDirectories(Environment.SystemDirectory).ToList();
        }
    }
}