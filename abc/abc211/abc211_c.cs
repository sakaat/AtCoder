// https://atcoder.jp/contests/abc211/submissions/24526683

using System;

class Program
{
    const string t = "chokudai";
    const int mod = 1000000007;

    static void Main()
    {
        var S = Console.ReadLine();

        var dp = new int[t.Length + 1];
        dp[0] = 1;

        for (int i = 0; i < S.Length; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (S[i] == t[j])
                {
                    dp[j + 1] += dp[j];
                    dp[j + 1] %= mod;
                }
            }
        }
        Console.WriteLine(dp[8]);
    }
}
