// https://atcoder.jp/contests/abc194/submissions/22558052

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

        var sum1 = 0L;
        var sum2 = 0L;
        for (var i = 0; i < N; i++)
        {
            sum1 += A[i];
            sum2 += A[i] * A[i];
        }
        Console.WriteLine(N * sum2 - sum1 * sum1);
    }
}
