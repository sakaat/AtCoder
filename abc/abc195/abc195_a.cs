// https://atcoder.jp/contests/abc195/submissions/22544006

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var M = input[0];
        var H = input[1];
        Console.WriteLine(H % M == 0 ? "Yes" : "No");
    }
}
