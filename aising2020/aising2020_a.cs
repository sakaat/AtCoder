// https://atcoder.jp/contests/aising2020/submissions/15333519

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var L = input[0];
        var R = input[1];
        var d = input[2];

        Console.WriteLine(R / d - (L - 1) / d);
    }
}
