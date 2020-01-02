// https://atcoder.jp/contests/abc121/submissions/9279662

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

            var ab = new long[N][];
            for (var i = 0; i < N; i++)
            {
                ab[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }
            Array.Sort(ab, (x, y) => x[0].CompareTo(y[0]));

            var temp = 0L;
            var result = 0L;
            for (var i = 0; i < N; i++)
            {
                if (M - temp > ab[i][1])
                {
                    result += ab[i][0] * ab[i][1];
                    temp += ab[i][1];
                }
                else
                {
                    result += ab[i][0] * (M - temp);
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
