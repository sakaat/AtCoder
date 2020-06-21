// https://atcoder.jp/contests/abc171/submissions/14588011

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        var p = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(p.OrderBy(x => x).Take(K).Sum());
    }
}
