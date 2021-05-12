// https://atcoder.jp/contests/abc200/submissions/22542239

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = new int[200];
        for (int i = 0; i < A.Length; i++)
        {
            b[A[i] % 200]++;
        }

        var result = 0L;
        for (int i = 0; i < b.Length; i++)
        {
            result += b[i] * (b[i] - 1L) / 2L;
        }
        Console.WriteLine(result);
    }
}
