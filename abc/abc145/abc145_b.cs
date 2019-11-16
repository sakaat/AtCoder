// https://atcoder.jp/contests/abc145/submissions/8485316

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();

            if (N % 2 > 0)
            {
                Console.WriteLine("No");
                return;
            }

            var l = S.Substring(0, N / 2);
            var r = S.Substring(N / 2, N / 2);
            Console.WriteLine(l == r ? "Yes" : "No");
        }
    }
}
