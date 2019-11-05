// https://atcoder.jp/contests/abc141/submissions/7526690

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];
        var Q = input[2];

        var list = Enumerable.Repeat(K, N).ToList();

        var A = new int[N];
        for (int i = 0; i < Q; i++)
        {
            A[int.Parse(Console.ReadLine()) - 1]++;
        }

        for (int i = 0; i < N; i++)
        {
            if (K - Q + A[i] > 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
