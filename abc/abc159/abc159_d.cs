// https://atcoder.jp/contests/abc159/submissions/11109035

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var B = new long[N + 1];
            for (var i = 0; i < N; i++)
            {
                B[A[i]]++;
            }

            var sum = 0L;
            for (var i = 1; i < N + 1; i++)
            {
                sum += B[i] * (B[i] - 1) / 2;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(sum - (B[A[i]] - 1));
            }
        }
    }
}
