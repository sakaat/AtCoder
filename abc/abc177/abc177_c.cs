// https://atcoder.jp/contests/abc177/submissions/16376028

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var mod = 1000000007;

        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

        var sum = 0L;
        for (int i = 0; i < N; i++)
        {
            sum += A[i];
            sum %= mod;
        }

        var result = 0L;
        for (int i = 0; i < N; i++)
        {
            sum -= A[i];
            if (sum < 0)
            {
                sum += mod;
            }
            result += A[i] * sum;
            result %= mod;
        }

        Console.WriteLine(result);
    }
}
