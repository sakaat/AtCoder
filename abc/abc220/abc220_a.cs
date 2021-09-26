// https://atcoder.jp/contests/abc220/submissions/26178801

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var C = input[2];

        var r = B / C * C;
        Console.WriteLine(A <= r ? r : -1);
    }
}
