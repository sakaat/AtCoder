// https://atcoder.jp/contests/abc173/submissions/15047261

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var H = input[0];
        var W = input[1];
        var K = input[2];

        var c = new char[H][];
        for (int i = 0; i < H; i++)
        {
            c[i] = Console.ReadLine().ToCharArray();
        }

        var result = 0;
        for (int i = 0; i < Math.Pow(2, H); i++)
        {
            var bH = Convert.ToString(i, 2).PadLeft(H, '0').ToCharArray();
            for (int j = 0; j < Math.Pow(2, W); j++)
            {
                var bW = Convert.ToString(j, 2).PadLeft(W, '0').ToCharArray();
                var black = 0;
                for (int k = 0; k < H; k++)
                {
                    for (int h = 0; h < W; h++)
                    {
                        if (bH[k] == '1' && bW[h] == '1' && c[k][h] == '#')
                        {
                            black++;
                        }
                    }
                }
                if (black == K)
                {
                    result++;
                }
            }
        }
        Console.WriteLine(result);
    }
}
