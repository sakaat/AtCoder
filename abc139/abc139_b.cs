// https://atcoder.jp/contests/abc139/submissions/7259256

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];

        Console.WriteLine(Math.Ceiling((B - 1.0) / (A - 1.0)));
    }
}
