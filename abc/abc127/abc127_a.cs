// https://atcoder.jp/contests/abc127/submissions/8379951

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
            var B = input[1];

            if (A < 6)
            {
                Console.WriteLine(0);
            }
            else if (6 <= A && A <= 12)
            {
                Console.WriteLine(B / 2);
            }
            else
            {
                Console.WriteLine(B);
            }
        }
    }
}
