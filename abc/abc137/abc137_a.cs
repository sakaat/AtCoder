// https://atcoder.jp/contests/abc137/submissions/7961857

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result =
                Math.Max(
                    Math.Max(
                        input[0] + input[1],
                        input[0] - input[1]
                    ),
                    input[0] * input[1]
                );
            Console.WriteLine(result);
        }
    }
}
