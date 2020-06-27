// https://atcoder.jp/contests/abc172/submissions/14784523

using System;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());

        var sum = 0L;
        for (int i = 1; i < N + 1; i++)
        {
            var q = N / i;
            sum += q * (q + 1) * i / 2;
        }
        Console.WriteLine(sum);
    }
}
