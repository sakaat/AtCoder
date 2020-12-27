// https://atcoder.jp/contests/abc186/submissions/19007915

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var H = input[0];
        var W = input[1];

        var m = 100;
        var A = new int[H][];
        for (int i = 0; i < H; i++)
        {
            A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            m = Math.Min(m, A[i].Min());
        }

        var result = 0;
        for (int i = 0; i < H; i++)
        {
            for (int j = 0; j < W; j++)
            {
                result += A[i][j] - m;
            }
        }
        Console.WriteLine(result);
    }
}
