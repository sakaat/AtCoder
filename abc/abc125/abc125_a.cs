// https://atcoder.jp/contests/abc125/submissions/8422583

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
            var T = input[2];

            Console.WriteLine(T / A * B);
        }
    }
}
