// https://atcoder.jp/contests/abc135/submissions/8233142

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = 0;
            for (int i = 0; i < N; i++)
            {
                if (p[i] != i + 1)
                {
                    result++;
                }
            }
            Console.WriteLine(result <= 2 ? "YES" : "NO");
        }
    }
}
