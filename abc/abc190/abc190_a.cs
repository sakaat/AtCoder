// https://atcoder.jp/contests/abc190/submissions/22543255

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
        Console.WriteLine(A + C > B ? "Takahashi" : "Aoki");
    }
}
