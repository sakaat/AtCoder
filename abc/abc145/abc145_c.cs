// https://atcoder.jp/contests/abc145/submissions/8488483

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var town = new int[N][];
            for (int i = 0; i < N; i++)
            {
                town[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            var dist = 0.0;
            var x = 0;
            var y = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    x = Math.Abs(town[i][0] - town[j][0]) * Math.Abs(town[i][0] - town[j][0]);
                    y = Math.Abs(town[i][1] - town[j][1]) * Math.Abs(town[i][1] - town[j][1]);
                    dist += Factorial(N - 1) * Math.Sqrt(x + y);
                }
            }

            Console.WriteLine(dist / Factorial(N));
        }

        private static int Factorial(int n)
        {
            var result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= (i + 1);
            }
            return result;
        }
    }
}
