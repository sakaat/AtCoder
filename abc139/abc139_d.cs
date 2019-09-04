// https://atcoder.jp/contests/abc139/submissions/7271002

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());

        Console.WriteLine(N * (N - 1) / 2);
    }
}
