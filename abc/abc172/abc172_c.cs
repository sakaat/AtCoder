// https://atcoder.jp/contests/abc172/submissions/14783023

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var N = input[0];
        var M = input[1];
        var K = input[2];

        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var B = Console.ReadLine().Split().Select(long.Parse).ToArray();

        var a = new long[N + 1];
        for (int i = 1; i <= N; i++)
        {
            a[i] = a[i - 1] + A[i - 1];
        }

        var b = new long[M + 1];
        for (int i = 1; i <= M; i++)
        {
            b[i] = b[i - 1] + B[i - 1];
        }

        var j = M;
        var answer = 0L;
        for (int i = 0; i <= N; i++)
        {
            if (a[i] > K)
            {
                break;
            }
            while (b[j] > K - a[i])
            {
                j--;
            }
            answer = Math.Max(answer, i + j);
        }
        Console.WriteLine(answer);
    }
}
