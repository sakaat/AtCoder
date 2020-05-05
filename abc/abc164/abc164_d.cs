// https://atcoder.jp/contests/abc164/submissions/12844007

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var T = new int[S.Length + 1];

        var MOD = 2019;
        var m10 = 1;
        for (int i = T.Length - 2; i >= 0; i--)
        {
            T[i] = (T[i + 1] + m10 * (S[i] - '0')) % MOD;
            m10 = m10 * 10 % MOD;
        }

        var s = new int[MOD];
        for (int i = 0; i < T.Length; i++)
        {
            s[T[i]]++;
        }
        Console.WriteLine(s.Select(x => x * (x - 1) / 2).Sum());
    }
}
