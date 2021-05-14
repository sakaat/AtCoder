// https://atcoder.jp/contests/abc199/submissions/22544324

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
        Console.WriteLine(A * A + B * B < C * C ? "Yes" : "No");
    }
}
