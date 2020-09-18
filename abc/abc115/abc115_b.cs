// https://atcoder.jp/contests/abc115/submissions/16817334

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var p = new int[N];
        for (int i = 0; i < N; i++)
        {
            p[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(p.Sum() - p.Max() / 2);
    }
}
