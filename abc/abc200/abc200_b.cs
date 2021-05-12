// https://atcoder.jp/contests/abc200/submissions/22541628

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        for (int i = 0; i < K; i++)
        {
            if (N % 200 == 0)
            {
                N /= 200;
            }
            else
            {
                N = N * 1000 + 200;
            }
        }
        Console.WriteLine(N);
    }
}
