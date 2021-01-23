// https://atcoder.jp/contests/abc188/submissions/19538370

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var X = input[0];
        var Y = input[1];

        if (Math.Min(X, Y) + 3 > Math.Max(X, Y))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
