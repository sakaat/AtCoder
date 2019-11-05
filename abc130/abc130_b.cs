// https://atcoder.jp/contests/abc130/submissions/8296528

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var X = input[1];

            var L = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var sum = 0;
            for (int i = 0; i < N; i++)
            {
                if ((sum += L[i]) > X)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }
            Console.WriteLine(N + 1);
        }
    }
}
