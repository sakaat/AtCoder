// https://atcoder.jp/contests/abc125/submissions/8515615

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var l = new int[N + 1];
            var r = new int[N + 1];

            l[0] = 0;
            for (int i = 0; i < N; i++)
            {
                l[i + 1] = Gcd(l[i], A[i]);
            }

            r[N] = 0;
            for (int i = N - 1; i > 0; i--)
            {
                r[i] = Gcd(r[i + 1], A[i]);
            }

            var m = new int[N + 1];
            for (int i = 0; i < N; i++)
            {
                m[i] = Gcd(l[i], r[i + 1]);
            }

            Console.WriteLine(m.Max());
        }

        private static int Gcd(int a, int b)
        {
            if (a < b)
            {
                return Gcd(b, a);
            }
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}
