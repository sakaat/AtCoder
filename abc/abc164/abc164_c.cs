// https://atcoder.jp/contests/abc164/submissions/12399846

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var S = new string[N];
        for (int i = 0; i < N; i++)
        {
            S[i] = Console.ReadLine();
        }

        Console.WriteLine(S.Distinct().Count());
    }
}
