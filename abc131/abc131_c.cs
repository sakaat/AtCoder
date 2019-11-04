// https://atcoder.jp/contests/abc131/submissions/8292782

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var C = input[2];
            var D = input[3];

            var a = (A - 1) - (A - 1) / C - (A - 1) / D + (A - 1) / Lcm(C, D);
            var b = B - B / C - B / D + B / Lcm(C, D);

            Console.WriteLine(b - a);
        }

        private static long Lcm(long a, long b)
        {
            return a * b / Gcd(a, b);
        }

        private static long Gcd(long a, long b)
        {
            if (a < b)
            {
                return Gcd(b, a);
            }
            while (b != 0)
            {
                var r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
