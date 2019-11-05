// https://atcoder.jp/contests/abc132/submissions/8272759

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = 0;
            for (var i = 1; i < N - 1; i++)
            {
                if (P[i - 1] < P[i] && P[i] < P[i + 1]
                    || P[i + 1] < P[i] && P[i] < P[i - 1])
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
