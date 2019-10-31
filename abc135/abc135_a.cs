// https://atcoder.jp/contests/abc135/submissions/8233129

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (input[0] % 2 == input[1] % 2)
            {
                Console.WriteLine((input[0] + input[1]) / 2);
            }
            else
            {
                Console.WriteLine("IMPOSSIBLE");
            }
        }
    }
}
