// https://atcoder.jp/contests/abc126/submissions/8399935

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
            var K = input[1];

            var result = new double[N];
            for (int i = 0; i < N; i++)
            {
                var score = i + 1;
                result[i] = 1.0 / N;
                while (score < K)
                {
                    score *= 2;
                    result[i] *= 0.5;
                }
            }
            Console.WriteLine(result.Sum());
        }
    }
}
