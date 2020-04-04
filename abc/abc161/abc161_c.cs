// https://atcoder.jp/contests/abc161/submissions/11546742

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = input[0];
            var K = input[1];

            Console.WriteLine(Math.Min(N % K, K - N % K));
        }
    }
}
