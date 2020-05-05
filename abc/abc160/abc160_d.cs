// https://atcoder.jp/contests/abc160/submissions/12849591

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var X = input[1];
        var Y = input[2];

        var result = new int[N];
        for (int i = 1; i < N; i++)
        {
            for (int j = i + 1; j <= N; j++)
            {
                result[Math.Min(j - i, Math.Abs(X - i) + Math.Abs(Y - j) + 1)]++;
            }
        }
        for (int i = 1; i < N; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
