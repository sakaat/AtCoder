// https://atcoder.jp/contests/abc178/submissions/16726808

using System;
using System.Linq;
using static System.Math;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var a = input[0];
        var b = input[1];
        var c = input[2];
        var d = input[3];

        Console.WriteLine(Max(Max(a * c, a * d), Max(b * c, b * d)));
    }
}
