// https://atcoder.jp/contests/abc202/submissions/22848960

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(21 - input.Sum());
    }
}
