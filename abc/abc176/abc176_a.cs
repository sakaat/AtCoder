// https://atcoder.jp/contests/abc176/submissions/16152838

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var X = input[1];
        var T = input[2];

        Console.WriteLine((N / X + Convert.ToInt32(N % X > 0)) * T);
    }
}
