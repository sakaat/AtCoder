// https://atcoder.jp/contests/abc156/submissions/10293040

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = input[0];
            var R = input[1];

            if (N >= 10)
            {
                Console.WriteLine($"{R}");
            }
            else
            {
                Console.WriteLine($"{R + 100 * (10 - N)}");
            }
        }
    }
}
