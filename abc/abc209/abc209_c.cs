// https://atcoder.jp/contests/abc209/submissions/24162906

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var C = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Array.Sort(C);

        var result = 1L;
        for (int i = 0; i < N; i++)
        {
            result *= Math.Max(0, C[i] - i);
            result %= 1000000007L;
        }
        Console.WriteLine(result);
    }
}
