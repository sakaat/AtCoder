// https://atcoder.jp/contests/abc205/submissions/23917252

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var C = input[2] % 2 == 0 ? 2 : 1;

        var result = string.Empty;
        if (Math.Pow(A, C) == Math.Pow(B, C))
        {
            result = "=";
        }
        else if (Math.Pow(A, C) > Math.Pow(B, C))
        {
            result = ">";
        }
        else
        {
            result = "<";
        }
        Console.WriteLine(result);
    }
}