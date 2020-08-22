// https://atcoder.jp/contests/abc176/submissions/16152722

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var M = A[0];
        var sum = 0;
        for (int i = 1; i < N; i++)
        {
            if (A[i] < M)
            {
                sum += M - A[i];
            }
            else
            {
                M = A[i];
            }
        }
        Console.WriteLine(sum);
    }
}
