// https://atcoder.jp/contests/abc137/submissions/7961948

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var K = input[0];
            var X = input[1];

            for (int i = X - K + 1; i < X + K; i++)
            {
                if (i < -1000000 || 1000000 < i)
                {
                    continue;
                }
                Console.Write(i);
                if (i != X + K - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
