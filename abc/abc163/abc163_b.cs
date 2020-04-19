// https://atcoder.jp/contests/abc163/submissions/12141452

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var days = N - A.Sum();

        Console.WriteLine(days >= 0 ? days : -1);
    }
}
