// https://atcoder.jp/contests/abc167/submissions/13233217

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];
        var X = input[2];

        var CA = new int[N][];
        for (int i = 0; i < N; i++)
        {
            CA[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        var result = int.MaxValue;
        for (int i = 0; i < Math.Pow(2, N); i++)
        {
            var b = Convert.ToString(i, 2).PadLeft(N, '0').ToCharArray();
            var c = 0;
            var a = new int[M];
            for (int j = 0; j < N; j++)
            {
                if (b[j] == '1')
                {
                    c += CA[j][0];
                    for (int k = 0; k < M; k++)
                    {
                        a[k] += CA[j][k + 1];
                    }
                }
            }
            if (a.Min() >= X && c < result)
            {
                result = c;
            }
        }
        Console.WriteLine(result == int.MaxValue ? -1 : result);
    }
}
