using System;
using System.IO;

namespace Library
{
    public class Logic
    {
        public static string PathCombine(string arg1, string arg2)
        {
            return Path.Combine(arg1, arg2);
        }

        public static string PathCombine(string arg1, string arg2, string arg3)
        {
            return Path.Combine(arg1, arg2, arg3);
        }

        public static string PathCombine(string arg1, string arg2, string arg3, string arg4)
        {
            return Path.Combine(arg1, arg2, arg4);
        }

        public static string PathCombine(params string[] args)
        {
            return Path.Combine(args);
        }
    }
}
