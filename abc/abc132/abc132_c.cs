// https://atcoder.jp/contests/abc132/submissions/8272996

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var D = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(D);

            Console.WriteLine(D[N / 2] - D[N / 2 - 1]);
        }
    }
}
