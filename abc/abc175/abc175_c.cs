// https://atcoder.jp/contests/abc175/submissions/15967505

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var X = Math.Abs(input[0]);
        var K = input[1];
        var D = input[2];
        var r = Math.Min(K, X / D);
        var X1 = X - r * D;

        if ((K - r) % 2 == 1)
        {
            Console.WriteLine(Math.Abs(X1 - D));
        }
        else
        {
            Console.WriteLine(X1);
        }
    }
}
