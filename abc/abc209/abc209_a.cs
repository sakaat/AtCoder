// https://atcoder.jp/contests/abc209/submissions/24162550

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];

        Console.WriteLine(Math.Max(0, B - A + 1));
    }
}
