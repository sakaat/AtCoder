// https://atcoder.jp/contests/abc154/submissions/9993992

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
            var K = input[1];

            var p = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var max = 0;
            for (int i = 0; i < K; i++)
            {
                max += p[i];
            }
            var temp = max;

            for (int i = 1; i < N - K + 1; i++)
            {
                temp -= p[i - 1];
                temp += p[i + K - 1];
                if (temp > max)
                {
                    max = temp;
                }
            }
            Console.WriteLine($"{(max + K) / 2.0}");
        }
    }
}
