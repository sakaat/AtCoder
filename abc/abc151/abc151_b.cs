// https://atcoder.jp/contests/abc151/submissions/9446921

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
            var K = input[1];
            var M = input[2];

            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (A.Sum() + K < N * M)
            {
                Console.WriteLine("-1");
                return;
            }
            else if (A.Sum() >= N * M)
            {
                Console.WriteLine("0");
                return;
            }
            Console.WriteLine(N * M - A.Sum());
        }
    }
}
