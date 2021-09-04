// https://atcoder.jp/contests/past202010-open/submissions/25617096

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];

        var s = new char[N][];
        for (int i = 0; i < N; i++)
        {
            s[i] = Console.ReadLine().ToCharArray();
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                var count = 0;
                if (i - 1 >= 0)
                {
                    if (j - 1 >= 0 && s[i - 1][j - 1] == '#')
                    {
                        count++;
                    }
                    if (s[i - 1][j] == '#')
                    {
                        count++;
                    }
                    if (j + 1 < M && s[i - 1][j + 1] == '#')
                    {
                        count++;
                    }
                }
                if (j - 1 >= 0 && s[i][j - 1] == '#')
                {
                    count++;
                }
                if (s[i][j] == '#')
                {
                    count++;
                }
                if (j + 1 < M && s[i][j + 1] == '#')
                {
                    count++;
                }
                if (i + 1 < N)
                {
                    if (j - 1 >= 0 && s[i + 1][j - 1] == '#')
                    {
                        count++;
                    }
                    if (s[i + 1][j] == '#')
                    {
                        count++;
                    }
                    if (j + 1 < M && s[i + 1][j + 1] == '#')
                    {
                        count++;
                    }
                }
                Console.Write(count);
            }
            Console.WriteLine();
        }
    }
}
