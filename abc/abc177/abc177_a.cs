// https://atcoder.jp/contests/abc177/submissions/16374026

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var D = input[0];
        var T = input[1];
        var S = input[2];
        Console.WriteLine(D > T * S ? "No" : "Yes");
    }
}
