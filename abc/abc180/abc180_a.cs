// https://atcoder.jp/contests/abc180/submissions/17490841

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var A = input[1];
        var B = input[2];
        Console.WriteLine(N - A + B);
    }
}