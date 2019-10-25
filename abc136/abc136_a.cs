// https://atcoder.jp/contests/abc136/submissions/8119316

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Math.Max(0, input[2] - (input[0] - input[1])));
        }
    }
}
