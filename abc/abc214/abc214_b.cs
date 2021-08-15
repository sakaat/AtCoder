// https://atcoder.jp/contests/abc214/submissions/25078300

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var S = input[0];
        var T = input[1];

        var result = 0;
        for (int i = 0; i <= S; i++)
        {
            for (int j = 0; i + j <= S; j++)
            {
                for (int k = 0; i + j + k <= S; k++)
                {
                    if (i * j * k <= T)
                    {
                        result++;
                    }
                }
            }
        }
        Console.WriteLine(result);
    }
}
