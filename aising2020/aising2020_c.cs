// https://atcoder.jp/contests/aising2020/submissions/15333765

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var sqrtN = (int)Math.Sqrt(N);

        var result = new int[N + 1];
        for (int i = 1; i <= sqrtN; i++)
        {
            for (int j = 1; j <= sqrtN; j++)
            {
                for (int k = 1; k <= sqrtN; k++)
                {
                    var v = i * i + j * j + k * k + i * j + j * k + k * i;
                    if (v <= N)
                    {
                        result[v]++;
                    }
                }
            }
        }
        for (int i = 1; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
