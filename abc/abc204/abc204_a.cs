// https://atcoder.jp/contests/abc204/submissions/23996342

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var x = input[0];
        var y = input[1];

        Console.WriteLine(x == y ? x : 3 - x - y);
    }
}
