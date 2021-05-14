// https://atcoder.jp/contests/abc199/submissions/22576326

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = Console.ReadLine();
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(Math.Max(0, B.Min() - A.Max() + 1));
    }
}
