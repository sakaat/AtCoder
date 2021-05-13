// https://atcoder.jp/contests/abc196/submissions/22544071

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var a = input[0];
        var b = input[1];
        var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var c = input2[0];
        var d = input2[1];
        Console.WriteLine(b - c);
    }
}
