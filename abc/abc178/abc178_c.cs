// https://atcoder.jp/contests/abc178/submissions/16757005

using System;

class Program
{
    static long MOD = 1000000007L;

    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var result = ModPow(10, N);
        result = (result + MOD - ModPow(9, N)) % MOD;
        result = (result + MOD - ModPow(9, N)) % MOD;
        result = (result + ModPow(8, N)) % MOD;
        Console.WriteLine(result);
    }

    static long ModPow(long x, long y)
    {
        var m = x % MOD;
        for (int i = 1; i < y; i++)
        {
            m = (m * x) % MOD;
        }
        return m;
    }
}
