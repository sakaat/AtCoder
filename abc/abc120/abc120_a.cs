// https://atcoder.jp/contests/abc120/submissions/9316922

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var C = input[2];

            Console.WriteLine(Math.Min(C, B / A));
        }
    }
}
