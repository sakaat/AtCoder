// https://atcoder.jp/contests/abc213/submissions/24896753

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        Console.WriteLine(B ^ A);
    }
}
