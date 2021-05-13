// https://atcoder.jp/contests/abc194/submissions/22557852

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var AB = new int[N][];
        for (int i = 0; i < N; i++)
        {
            AB[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        var result = int.MaxValue;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == j && result > AB[i][0] + AB[j][1])
                {
                    result = AB[i][0] + AB[j][1];
                }
                else if (i != j && result > Math.Max(AB[i][0], AB[j][1]))
                {
                    result = Math.Max(AB[i][0], AB[j][1]);
                }
            }
        }
        Console.WriteLine(result);
    }
}
