// https://atcoder.jp/contests/abc127/submissions/8380301

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var M = input[1];

            var l = 1;
            var r = N;
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var L = input[0];
                var R = input[1];

                l = Math.Max(l, L);
                r = Math.Min(r, R);
            }
            Console.WriteLine(Math.Max(0, r - l + 1));
        }
    }
}
