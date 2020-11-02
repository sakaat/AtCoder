// https://atcoder.jp/contests/abc181/submissions/17829447

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long sum(long x) => x * (x + 1) / 2;

        var N = int.Parse(Console.ReadLine());
        var result = 0L;

        for (int i = 0; i < N; i++)
        {
            var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            result += sum(AB[1]);
            result -= sum(AB[0] - 1);
        }
        Console.WriteLine(result);
    }
}