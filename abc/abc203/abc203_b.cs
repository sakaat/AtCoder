// https://atcoder.jp/contests/abc203/submissions/23917452

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        var result = 0;
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= K; j++)
            {
                result += 100 * i + j;
            }
        }
        Console.WriteLine(result);
    }
}