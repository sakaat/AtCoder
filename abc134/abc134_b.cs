// https://atcoder.jp/contests/abc134/submissions/8245562

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Math.Ceiling(input[0] / (2 * input[1] + 1.0)));
        }
    }
}
