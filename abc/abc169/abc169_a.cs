// https://atcoder.jp/contests/abc169/submissions/13904432

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(input[0] * input[1]);
    }
}
