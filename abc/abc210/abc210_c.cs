// https://atcoder.jp/contests/abc210/submissions/24376743

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];
        var c = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var d = c.Take(K).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var result = d.Count();
        var m = result;

        for (int i = K; i < N; i++)
        {
            if (d[c[i - K]] == 1)
            {
                m--;
            }
            d[c[i - K]]--;

            if (d.ContainsKey(c[i]))
            {
                if (d[c[i]] == 0)
                {
                    m++;
                }
                d[c[i]]++;
            }
            else
            {
                d[c[i]] = 1;
                m++;
            }
            result = Math.Max(result, m);
        }
        Console.WriteLine(result);
    }
}
