// https://atcoder.jp/contests/abc122/submissions/9267194

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var Q = input[1];

            var S = Console.ReadLine();

            var lr = new int[Q][];
            for (int i = 0; i < Q; i++)
            {
                lr[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            var t = new int[N + 1];
            for (int i = 1; i < N; i++)
            {
                if (S[i - 1] == 'A' && S[i] == 'C')
                {
                    t[i + 1] = t[i] + 1;
                }
                else
                {
                    t[i + 1] = t[i];
                }
            }

            for (int i = 0; i < Q; i++)
            {
                Console.WriteLine(t[lr[i][1]] - t[lr[i][0]]);
            }
        }
    }
}
