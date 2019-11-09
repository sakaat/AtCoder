// https://atcoder.jp/contests/abc128/submissions/8305891

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = input[0];
            var P = input[1];

            Console.WriteLine((3 * A + P) / 2);
        }
    }
}
