// https://atcoder.jp/contests/abc188/submissions/19648441

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

        var half = long.Parse(Math.Pow(2, N).ToString()) / 2L;

        var M1 = 0L;
        var M2 = 0L;
        for (var i = 0L; i < half; i++)
        {
            if (M1 < A[i])
            {
                M1 = A[i];
            }
            if (M2 < A[i + half])
            {
                M2 = A[i + half];
            }
        }
        var m = Math.Min(M1, M2);
        Console.WriteLine(A.ToList().IndexOf(m) + 1);
    }
}
