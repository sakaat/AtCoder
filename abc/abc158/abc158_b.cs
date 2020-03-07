// https://atcoder.jp/contests/abc158/submissions/10641738

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
            var A = input[1];
            var B = input[2];

            var result = N / (A + B) * A + Math.Min(A, N % (A + B));
            Console.WriteLine(result);
        }
    }
}
