// https://atcoder.jp/contests/abc121/submissions/9279460

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
            var M = input[1];
            var C = input[2];

            var B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var A = new int[N][];
            for (int i = 0; i < N; i++)
            {
                A[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            var result = 0;
            for (int i = 0; i < N; i++)
            {
                var temp = A[i].Zip(B, (a, b) => a * b).Sum();
                result = temp + C > 0 ? ++result : result;
            }

            Console.WriteLine(result);
        }
    }
}
