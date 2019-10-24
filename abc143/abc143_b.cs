// https://atcoder.jp/contests/abc143/submissions/8107486

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var d = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    result += d[i] * d[j];
                }
            }
            Console.WriteLine(result);
        }
    }
}
