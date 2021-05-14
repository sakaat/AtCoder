// https://atcoder.jp/contests/abc193/submissions/22575048

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var APX = new int[N][];
        for (int i = 0; i < N; i++)
        {
            APX[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        var result = int.MaxValue;
        for (int i = 0; i < N; i++)
        {
            if (APX[i][0] < APX[i][2] && result > APX[i][1])
            {
                result = APX[i][1];
            }
        }
        Console.WriteLine(result == int.MaxValue ? -1 : result);
    }
}
