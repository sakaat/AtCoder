// https://atcoder.jp/contests/abc197/submissions/22650868

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var H = input[0];
        var W = input[1];
        var X = input[2] - 1;
        var Y = input[3] - 1;

        var S = new char[H][];
        for (int i = 0; i < H; i++)
        {
            S[i] = Console.ReadLine().ToCharArray();
        }

        var result = 0;

        var x = X;
        var y = Y;
        while (x < H && S[x][y] == '.')
        {
            result++;
            x++;
        }

        x = X;
        y = Y;
        while (y < W && S[x][y] == '.')
        {
            result++;
            y++;
        }

        x = X;
        y = Y;
        while (x >= 0 && S[x][y] == '.')
        {
            result++;
            x--;
        }

        x = X;
        y = Y;
        while (y >= 0 && S[x][y] == '.')
        {
            result++;
            y--;
        }

        Console.WriteLine(result - 3);
    }
}
