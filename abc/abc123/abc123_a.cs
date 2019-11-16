// https://atcoder.jp/contests/abc123/submissions/8438039

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = new int[6].Select(_ => int.Parse(Console.ReadLine())).ToArray();
            Console.WriteLine(input[4] - input[0] > input[5] ? ":(" : "Yay!");
        }
    }
}
