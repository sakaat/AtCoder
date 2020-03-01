// https://atcoder.jp/contests/abc157/submissions/10470543

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var A = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            var N = int.Parse(Console.ReadLine());

            var b = new int[N];
            for (int i = 0; i < N; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            var C = new bool[3][];
            for (int i = 0; i < 3; i++)
            {
                C[i] = new bool[3];
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (A[j][k] == b[i])
                        {
                            C[j][k] = true;
                        }
                    }
                }
            }

            var result = false;
            for (int i = 0; i < 3; i++)
            {
                if ((C[i][0] && C[i][1] && C[i][2]) || (C[0][i] && C[1][i] && C[2][i]))
                {
                    result = true;
                }
            }
            if ((C[0][0] && C[1][1] && C[2][2]) || (C[2][0] && C[1][1] && C[0][2]))
            {
                result = true;
            }

            Console.WriteLine($"{(result ? "Yes" : "No")}");
        }
    }
}
