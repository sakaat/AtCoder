// https://atcoder.jp/contests/abc186/submissions/19007783

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var W = input[1];

        Console.WriteLine(N / W);
    }
}
