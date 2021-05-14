// https://atcoder.jp/contests/abc193/submissions/22575626

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var hSet = new HashSet<long>();
        for (var i = 2; i <= Math.Sqrt(N); i++)
        {
            for (var j = 2; Math.Pow(i, j) <= N; j++)
            {
                hSet.Add(long.Parse(Math.Pow(i, j).ToString()));
            }
        }
        Console.WriteLine(N - hSet.Count);
    }
}
