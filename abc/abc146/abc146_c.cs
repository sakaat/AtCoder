// https://atcoder.jp/contests/abc146/submissions/8637354

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var X = input[2];

            if (A + B >= X)
            {
                Console.WriteLine(0);
                return;
            }

            if (A * Math.Pow(10, 9) + B * 10 <= X)
            {
                Console.WriteLine(Math.Pow(10, 9));
                return;
            }

            var n = (long)Math.Pow(10, 9);
            var result = 0L;
            while (n > 0L)
            {
                if (A * n + B * n.ToString().Length <= X)
                {
                    result = Math.Min(n * 10 - 1, (X - B * n.ToString().Length) / A);
                    break;
                }
                n /= 10L;
            }

            Console.WriteLine(Math.Max(0, result));
        }
    }
}
