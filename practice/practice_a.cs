// https://atcoder.jp/contests/practice/submissions/7030932

using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var b = input[0];
        var c = input[1];
        var s = Console.ReadLine();
        Console.WriteLine($"{a + b + c} {s}");
    }
}
