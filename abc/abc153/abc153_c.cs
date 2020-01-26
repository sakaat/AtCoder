// https://atcoder.jp/contests/abc153/submissions/9749505

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

            var H = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(H);
            Array.Reverse(H);

            for (var i = 0; i < K; i++)
            {
                if (i >= H.Length)
                {
                    break;
                }
                H[i] = 0L;
            }

            Console.WriteLine(H.Sum());
        }
    }
}
