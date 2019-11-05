// https://atcoder.jp/contests/abc131/submissions/8292267

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var L = input[1];

            var min = Math.Abs(L);
            var result = 0;
            for (int i = 1; i <= N; i++)
            {
                if (Math.Abs(L + i - 1) < Math.Abs(min))
                {
                    min = L + i - 1;
                }
                result += L + i - 1;
            }
            Console.WriteLine(result - min);
        }
    }
}
