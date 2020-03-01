// https://atcoder.jp/contests/abc157/submissions/10455997

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = input[0];
            var M = input[1];

            var s = new int[M][];
            for (int i = 0; i < M; i++)
            {
                s[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            for (int i = 0; i < M; i++)
            {
                if (N > 1 && s[i][0] == 1 && s[i][1] == 0)
                {
                    Console.WriteLine("-1");
                    return;
                }
                for (int j = 0; j < M; j++)
                {
                    if (s[i][0] == s[j][0] && s[i][1] != s[j][1])
                    {
                        Console.WriteLine("-1");
                        return;
                    }
                }
            }

            var c = new char[N];
            for (int i = 0; i < N; i++)
            {
                c[i] = '0';
            }
            for (int i = 0; i < M; i++)
            {
                c[s[i][0] - 1] = char.Parse(s[i][1].ToString());
            }
            if (N > 1 && c[0] == '0')
            {
                c[0] = '1';
            }
            Console.WriteLine(int.Parse(string.Join(string.Empty, c)));
        }
    }
}
