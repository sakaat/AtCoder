// https://atcoder.jp/contests/abc192/submissions/22540838

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        int g1(int x) => int.Parse(String.Concat(x.ToString().OrderBy(c => -c)));
        int g2(int x) => int.Parse(String.Concat(x.ToString().OrderBy(c => c)));
        int f(int x) => g1(x) - g2(x);

        var a = N;
        for (var i = 0; i < K; i++)
        {
            a = f(a);
        }
        Console.WriteLine(a);
    }
}
