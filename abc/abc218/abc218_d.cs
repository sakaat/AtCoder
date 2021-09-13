// https://atcoder.jp/contests/abc218/submissions/25819094

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var hs = new HashSet<(int, int)>();
        var xy = new (int, int)[N];
        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            xy[i] = (input[0], input[1]);
            hs.Add(xy[i]);
        }
        Array.Sort(xy);

        var result = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (xy[i].Item1 >= xy[j].Item1 || xy[i].Item2 >= xy[j].Item2)
                {
                    continue;
                }
                if (hs.Contains((xy[i].Item1, xy[j].Item2)) && hs.Contains((xy[j].Item1, xy[i].Item2)))
                {
                    result++;
                }
            }
        }
        Console.WriteLine(result);
    }
}
