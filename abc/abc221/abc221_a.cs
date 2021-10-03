// https://atcoder.jp/contests/abc221/submissions/26339553

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(Math.Pow(32, input[0] - input[1]));
    }
}
