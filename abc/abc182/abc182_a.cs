// https://atcoder.jp/contests/abc182/submissions/18004093

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        Console.WriteLine(2 * A + 100 - B);
    }
}
