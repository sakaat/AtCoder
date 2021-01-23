// https://atcoder.jp/contests/abc187/submissions/19658836

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var S = new HashSet<string>();
        for (int i = 0; i < N; i++)
        {
            S.Add(Console.ReadLine());
        }
        foreach (var s in S)
        {
            if (S.Contains("!" + s))
            {
                Console.WriteLine(s);
                return;
            }
        }
        Console.WriteLine("satisfiable");
    }
}
