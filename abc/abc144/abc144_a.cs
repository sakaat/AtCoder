// https://atcoder.jp/contests/abc144/submissions/8147611

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (1 <= input[0] && input[0] <= 9 && 1 <= input[1] && input[1] <= 9)
            {
                Console.WriteLine(input[0] * input[1]);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
