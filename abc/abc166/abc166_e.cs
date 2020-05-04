// https://atcoder.jp/contests/abc166/submissions/12812585

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

        var sum = new long[N];
        var diff = new long[N];

        for (var i = 0; i < N; i++)
        {
            if (i - A[i] >= 0)
            {
                diff[i - A[i]]++;
            }
            if (i + A[i] < N)
            {
                sum[i + A[i]]++;
            }
        }
        Console.WriteLine(sum.Zip(diff, (s, d) => s * d).Sum());
    }
}
