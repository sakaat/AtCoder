// https://atcoder.jp/contests/abc139/submissions/7288871

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var E = new int[N][];
        for (int i = 0; i < N; i++)
        {
            E[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        var result = new double[4];

        var x = 0.0;
        var y = 0.0;
        for (int i = 0; i < N; i++)
        {
            if ((E[i][0] >= 0 && E[i][1] >= 0)
                || (E[i][0] < 0 && -E[i][0] < E[i][1])
                || (E[i][1] < 0 && E[i][0] > -E[i][1])
                )
            {
                x += E[i][0];
                y += E[i][1];
            }
        }
        result[0] = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));

        x = 0;
        y = 0;
        for (int i = 0; i < N; i++)
        {
            if ((E[i][0] <= 0 && E[i][1] >= 0)
                || (E[i][0] > 0 && E[i][0] < E[i][1])
                || (E[i][1] < 0 && E[i][0] > -E[i][1])
                )
            {
                x += E[i][0];
                y += E[i][1];
            }
        }
        result[1] = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));

        x = 0;
        y = 0;
        for (int i = 0; i < N; i++)
        {
            if ((E[i][0] <= 0 && E[i][1] <= 0)
                || (E[i][0] > 0 && -E[i][0] > E[i][1])
                || (E[i][1] > 0 && E[i][0] < -E[i][1])
                )
            {
                x += E[i][0];
                y += E[i][1];
            }
        }
        result[2] = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));

        x = 0;
        y = 0;
        for (int i = 0; i < N; i++)
        {
            if ((E[i][0] >= 0 && E[i][1] <= 0)
                || (E[i][0] < 0 && E[i][0] > E[i][1])
                || (E[i][1] > 0 && E[i][0] > E[i][1])
                )
            {
                x += E[i][0];
                y += E[i][1];
            }
        }
        result[3] = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));

        Console.WriteLine(result.Max());
    }
}
