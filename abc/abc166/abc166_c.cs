// https://atcoder.jp/contests/abc166/submissions/12784359

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];

        var H = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var AB = new int[N];
        for (int i = 0; i < M; i++)
        {
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = input[0];
            var B = input[1];

            AB[A - 1] = Math.Max(AB[A - 1], H[B - 1]);
            AB[B - 1] = Math.Max(AB[B - 1], H[A - 1]);
        }

        var result = 0;
        for (int i = 0; i < N; i++)
        {
            if (H[i] > AB[i])
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
