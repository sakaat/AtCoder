// https://atcoder.jp/contests/abc125/submissions/14522750

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = Console.ReadLine();
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var AA = A.Select(x => Math.Abs(x));

        Console.WriteLine(A.Any(x => x == 0) || A.Count(x => x < 0) % 2 == 0 ? AA.Sum() : AA.Sum() - 2 * AA.Min());
    }
}
