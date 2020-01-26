// https://atcoder.jp/contests/abc153/submissions/9737236

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = input[0];
            var A = input[1];

            Console.WriteLine(Math.Ceiling(H / (double)A));
        }
    }
}
