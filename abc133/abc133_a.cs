// https://atcoder.jp/contests/abc133/submissions/8263886

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Math.Min(input[0] * input[1], input[2]));
        }
    }
}
