// https://atcoder.jp/contests/abc152/submissions/9612044

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var min_value = N + 1;
            var result = 0;
            for (int i = 0; i < N; i++)
            {
                if (P[i] < min_value)
                {
                    result++;
                    min_value = P[i];
                }
                if (min_value == 1)
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
