// https://atcoder.jp/contests/abc181/submissions/17843155

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
            xy[i] = new int[2];
            xy[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for (int i = 0; i < N - 2; i++)
        {
            for (int j = i + 1; j < N - 1; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    var x1 = xy[i][0];
                    var y1 = xy[i][1];
                    var x2 = xy[j][0];
                    var y2 = xy[j][1];
                    var x3 = xy[k][0];
                    var y3 = xy[k][1];
                    x1 -= x3;
                    x2 -= x3;
                    y1 -= y3;
                    y2 -= y3;
                    if (x1 * y2 == x2 * y1)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
        }
        Console.WriteLine("No");
    }
}