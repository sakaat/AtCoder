// https://atcoder.jp/contests/abc216/submissions/25506373

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var xy = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
        var s = string.Empty;

        if (0 <= xy[1] && xy[1] <= 2)
        {
            s = "-";
        }
        else if (7 <= xy[1] && xy[1] <= 9)
        {
            s = "+";
        }
        Console.WriteLine($"{xy[0]}{s}");
    }
}
