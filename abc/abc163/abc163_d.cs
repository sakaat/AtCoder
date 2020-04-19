// https://atcoder.jp/contests/abc163/submissions/12149517

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var MOD = 1000000007L;

        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        var result = 0L;
        for (var i = K; i < N + 2; i++)
        {
            var min = i * (i - 1) / 2;
            var max = i * (2 * N - i + 1) / 2;
            result += (max - min + 1) % MOD;
        }
        Console.WriteLine(result % MOD);
    }
}
