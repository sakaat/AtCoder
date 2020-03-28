// https://atcoder.jp/contests/abc160/submissions/11315119

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
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var distance = new long[N];
            for (var i = 0; i < K - 1; i++)
            {
                distance[i] = A[i + 1] - A[i];
            }
            distance[K - 1] = A[0] + N - A[K - 1];

            Console.WriteLine(distance.Sum() - distance.Max());
        }
    }
}
