// https://atcoder.jp/contests/abc159/submissions/11101921

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
            var M = input[1];

            Console.WriteLine(N * (N - 1) / 2 + M * (M - 1) / 2);
        }
    }
}
