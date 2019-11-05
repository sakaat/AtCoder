// https://atcoder.jp/contests/abc129/submissions/8303995

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static readonly int mod = 1000000007;

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var M = input[1];

            var a = new int[M];
            for (var i = 0; i < M; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            var dp = new int[N + 1];
            dp[0] = 1;
            var index = 0;
            for (var i = 1; i <= N; i++)
            {
                if (index < M && a[index] == i)
                {
                    dp[i] = 0;
                    index++;
                }
                else
                {
                    dp[i] = (dp[i - 1] + (i != 1 ? dp[i - 2] : 0)) % mod;
                }
            }
            Console.WriteLine(dp[N]);
        }
    }
}
