// https://atcoder.jp/contests/abc175/submissions/15962095

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var L = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(L);

        var result = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    if (L[i] != L[j] && L[j] != L[k] && L[k] != L[i])
                    {
                        if (L[k] < L[i] + L[j])
                        {
                            result++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(result);
    }
}
