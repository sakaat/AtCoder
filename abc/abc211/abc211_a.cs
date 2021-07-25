// https://atcoder.jp/contests/abc211/submissions/24524962

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        Console.WriteLine((A - B) / 3.0 + B);
    }
}
