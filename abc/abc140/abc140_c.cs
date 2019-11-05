// https://atcoder.jp/contests/abc140/submissions/7390650

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var A = new int[N];

        A[0] = B[0];
        for (int i = 1; i < N - 1; i++)
        {
            A[i] = Math.Min(B[i - 1], B[i]);
        }
        A[N - 1] = B[N - 2];

        Console.WriteLine(A.Sum());
    }
}
