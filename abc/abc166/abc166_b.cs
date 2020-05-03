// https://atcoder.jp/contests/abc166/submissions/12777407

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        var s = new HashSet<int>();
        for (int i = 0; i < K; i++)
        {
            var _ = Console.ReadLine();
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < input.Length; j++)
            {
                s.Add(input[j]);
            }
        }

        var snuke = Enumerable.Range(1, N).ToHashSet();
        Console.WriteLine(snuke.Except(s).Count());
    }
}
