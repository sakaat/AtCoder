// https://atcoder.jp/contests/abc207/submissions/23923527

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(input.Sum() - input.Min());
    }
}
