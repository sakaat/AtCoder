// https://atcoder.jp/contests/abc124/submissions/8427640

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var H = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var result = 0;
            var t = H[0];
            for (int i = 0; i < N; i++)
            {
                if (H[i] >= t)
                {
                    result++;
                }
                t = Math.Max(H[i], t);
            }
            Console.WriteLine(result);
        }
    }
}
