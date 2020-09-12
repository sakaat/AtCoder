// https://atcoder.jp/contests/abc120/submissions/16642816

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var l0 = S.Count(c => c == '0');
        var l1 = S.Count(c => c == '1');
        Console.WriteLine(2 * Math.Min(l0, l1));
    }
}
