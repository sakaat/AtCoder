// https://atcoder.jp/contests/abc214/submissions/25079456

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var S = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var T = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var t = Array.IndexOf(T, T.Min());

        var dp = new int[N];
        dp[0] = T[t];

        for (int i = 0; i < N - 1; i++)
        {
            dp[i + 1] = Math.Min(dp[i] + S[(t + i) % N], T[(t + i + 1) % N]);
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(dp[(N - t + i) % N]);
        }
    }
}
