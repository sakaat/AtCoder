// https://atcoder.jp/contests/abc162/submissions/11843143

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();

            var R = new List<int>();
            var G = new List<int>();
            var B = new List<int>();
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'R')
                {
                    R.Add(i);
                }
                else if (S[i] == 'G')
                {
                    G.Add(i);
                }
                else
                {
                    B.Add(i);
                }
            }

            var result = 0L;
            for (int i = 0; i < R.Count; i++)
            {
                var ix = R[i];
                for (int j = 0; j < G.Count; j++)
                {
                    var jx = G[j];

                    var d = Math.Abs(ix - jx);
                    if (B.Contains(Math.Max(ix, jx) + d))
                    {
                        result--;
                    }
                    if (B.Contains(Math.Min(ix, jx) - d))
                    {
                        result--;
                    }
                    if ((ix + jx) % 2 == 0 && B.Contains((ix + jx) / 2))
                    {
                        result--;
                    }
                    result += B.Count;
                }
            }
            Console.WriteLine(result);
        }
    }
}
