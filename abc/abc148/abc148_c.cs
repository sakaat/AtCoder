// https://atcoder.jp/contests/abc148/submissions/9068629

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var result = Lcm(input[0], input[1]);
            Console.WriteLine(result);
        }

        public static long Lcm(long a, long b)
        {
            return a * b / Gcd(a, b);
        }

        public static long Gcd(long a, long b)
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
