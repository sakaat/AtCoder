// https://atcoder.jp/contests/abc133/submissions/8263950

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var D = input[1];

            var X = new int[N][];
            for (int i = 0; i < N; i++)
            {
                X[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            var result = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    var dist = 0;
                    for (int k = 0; k < D; k++)
                    {
                        dist += (X[i][k] - X[j][k]) * (X[i][k] - X[j][k]);
                    }
                    var t = (int)Math.Ceiling(Math.Sqrt(dist));
                    if (t * t == dist)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
