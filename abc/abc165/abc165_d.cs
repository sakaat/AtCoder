// https://atcoder.jp/contests/abc165/submissions/12653097

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var N = input[2];

        long Calc(long x) => (A * x / B) - (A * (x / B));

        Console.WriteLine(Calc(Math.Min(B - 1, N)));
    }
}
