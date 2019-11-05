// https://atcoder.jp/contests/abc143/submissions/8107390

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Math.Max(0, input[0] - 2 * input[1]));
        }
    }
}
