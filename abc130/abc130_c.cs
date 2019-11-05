// https://atcoder.jp/contests/abc130/submissions/8296675

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var W = input[0];
            var H = input[1];
            var x = input[2];
            var y = input[3];

            Console.WriteLine($"{W * H / 2.0} {(2 * x == W && 2 * y == H ? 1 : 0)}");
        }
    }
}
