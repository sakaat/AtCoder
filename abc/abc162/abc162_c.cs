// https://atcoder.jp/contests/abc162/submissions/11796944

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var K = int.Parse(Console.ReadLine());

            var result = 0L;
            for (int i = 1; i <= K; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    for (int k = 1; k <= K; k++)
                    {
                        result += Gcd(Gcd(i, j), k);
                    }
                }
            }
            Console.WriteLine(result);
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
