// https://atcoder.jp/contests/abc165/submissions/12682851

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];
        var Q = input[2];

        var a = new int[Q];
        var b = new int[Q];
        var c = new int[Q];
        var d = new int[Q];
        for (int i = 0; i < Q; i++)
        {
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            a[i] = input2[0];
            b[i] = input2[1];
            c[i] = input2[2];
            d[i] = input2[3];
        }

        var A = new int[N + 1];
        var result = 0;

        void Solver(int n, int t)
        {
            if (t == N + 1)
            {
                var sum = 0;
                for (int i = 0; i < Q; i++)
                {
                    if (A[b[i]] - A[a[i]] == c[i])
                    {
                        sum += d[i];
                    }
                }
                if (sum > result)
                {
                    result = sum;
                }
                return;
            }
            A[t] = n;
            while (n <= M)
            {
                Solver(n, t + 1);
                n++;
            }
            return;
        }
        Solver(1, 1);

        Console.WriteLine(result);
    }
}
