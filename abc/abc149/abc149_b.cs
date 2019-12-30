// https://atcoder.jp/contests/abc149/submissions/9230162

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var K = input[2];

            if (K <= A)
            {
                Console.WriteLine($"{A - K} {B}");
            }
            else if (K <= A + B)
            {
                Console.WriteLine($"0 {B - (K - A)}");
            }
            else
            {
                Console.WriteLine("0 0");
            }
        }
    }
}
