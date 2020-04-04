// https://atcoder.jp/contests/abc161/submissions/11546663

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

            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            Array.Reverse(A);
            var sum = A.Sum();

            for (var i = 0; i < M; i++)
            {
                if (A[i] * 4 * M < sum)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
