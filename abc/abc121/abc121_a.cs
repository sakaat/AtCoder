// https://atcoder.jp/contests/abc121/submissions/9279368

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var H = input[0];
            var W = input[1];

            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var h = input[0];
            var w = input[1];

            Console.WriteLine($"{(H - h) * (W - w)}");
        }
    }
}
