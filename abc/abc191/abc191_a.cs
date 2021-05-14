// https://atcoder.jp/contests/abc191/submissions/22543382

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var V = input[0];
        var T = input[1];
        var S = input[2];
        var D = input[3];

        Console.WriteLine(V * T <= D && D <= V * S ? "No" : "Yes");
    }
}
