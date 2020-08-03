// https://atcoder.jp/contests/abc174/submissions/15640692

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var N = input[0];
        var D = input[1];
        var D2 = D * D;

        var result = 0;
        for (int i = 0; i < N; i++)
        {
            var input2 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var X = input2[0];
            var Y = input2[1];
            if (X * X + Y * Y <= D2)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
