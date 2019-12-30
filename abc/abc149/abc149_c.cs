// https://atcoder.jp/contests/abc149/submissions/9230269

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var X = int.Parse(Console.ReadLine());

            int p = X;
            while (!IsPrime(p))
            {
                p++;
            }
            Console.WriteLine(p);
        }

        private static bool IsPrime(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
