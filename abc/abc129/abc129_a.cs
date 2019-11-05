// https://atcoder.jp/contests/abc129/submissions/8302981

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            Console.WriteLine(Math.Min(Math.Min(input[0] + input[1], input[1] + input[2]), input[2] + input[0]));
        }
    }
}
