// https://atcoder.jp/contests/abc217/submissions/25617492

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var P = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var Q = new int[N];
        for (int i = 0; i < N; i++)
        {
            Q[P[i] - 1] = i + 1;
        }
        foreach (var q in Q)
        {
            Console.Write(q + " ");
        }
    }
}
