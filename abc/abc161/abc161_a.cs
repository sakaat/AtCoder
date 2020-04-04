// https://atcoder.jp/contests/abc161/submissions/11546573

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var X = input[0];
            var Y = input[1];
            var Z = input[2];

            Console.WriteLine($"{Z} {X} {Y}");
        }
    }
}
