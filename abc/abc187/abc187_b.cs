// https://atcoder.jp/contests/abc187/submissions/19658620

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var xy = new int[N][];
        for (int i = 0; i < N; i++)
        {
            xy[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        var result = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (Math.Abs(xy[i][1] - xy[j][1]) <= Math.Abs(xy[i][0] - xy[j][0]))
                {
                    result++;
                }
            }
        }
        Console.WriteLine(result);
    }
}
