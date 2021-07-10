// https://atcoder.jp/contests/abc204/submissions/24098193

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(A.Where(x => x > 10).Select(x => x - 10).Sum());
    }
}
