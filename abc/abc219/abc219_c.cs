// https://atcoder.jp/contests/abc219/submissions/25973989

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var X = Console.ReadLine();

        var a = "abcdefghijklmnopqrstuvwxyz";
        var d = new Dictionary<char, char>();
        for (var i = 0; i < X.Length; i++)
        {
            d.Add(X[i], a[i]);
        }

        var N = int.Parse(Console.ReadLine());

        var result = new List<(string, string)>();
        for (var i = 0; i < N; i++)
        {
            var s = Console.ReadLine();
            result.Add((s, string.Join("", s.Select(x => d[x]))));
        }

        var result2 = result.OrderBy(x => x.Item2).Select(x => x.Item1).ToArray();
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(result2[i]);
        }
    }
}
