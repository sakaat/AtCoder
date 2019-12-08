// https://atcoder.jp/contests/abc147/submissions/8845694

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (input[0] + input[1] + input[2] >= 22)
            {
                Console.WriteLine("bust");
            }
            else
            {
                Console.WriteLine("win");
            }
        }
    }
}
