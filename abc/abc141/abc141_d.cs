// https://atcoder.jp/contests/abc141/submissions/12855778

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var N = input[0];
        var M = input[1];

        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Array.Sort(A);
        Array.Reverse(A);

        while (M > 0)
        {
            A[0] /= 2;
            M--;
            if (M == 0)
            {
                break;
            }
            for (int i = 1; i < N; i++)
            {
                if (A[0] > A[i])
                {
                    Array.Sort(A);
                    Array.Reverse(A);
                    break;
                }
                A[i] /= 2;
                M--;
                if (M == 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine(A.Sum());
    }
}
