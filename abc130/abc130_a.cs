// https://atcoder.jp/contests/abc130/submissions/8296460

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var X = input[0];
            var A = input[1];

            Console.WriteLine(X < A ? 0 : 10);
        }
    }
}
