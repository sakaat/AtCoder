// https://atcoder.jp/contests/abc169/submissions/13904468

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        Console.WriteLine(Math.Floor(input[0] * input[1]));
    }
}
