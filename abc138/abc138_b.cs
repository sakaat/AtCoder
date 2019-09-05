// https://atcoder.jp/contests/abc138/submissions/7037740

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var result = A.Select(x => 1.0 / x).Sum();
        Console.WriteLine($"{1 / result}");
    }
}
