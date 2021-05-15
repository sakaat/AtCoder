// https://atcoder.jp/contests/abc185/submissions/19008416

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(input.Min());
    }
}
