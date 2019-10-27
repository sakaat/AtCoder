// https://atcoder.jp/contests/abc144/submissions/8160350

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = long.Parse(Console.ReadLine());

            var ub = (int)Math.Floor(Math.Sqrt(N));
            for (int i = ub; i > 0; i--)
            {
                if (N % i == 0)
                {
                    var l = i;
                    var r = N / i;
                    Console.WriteLine(l + r - 2);
                    break;
                }
            }
        }
    }
}
