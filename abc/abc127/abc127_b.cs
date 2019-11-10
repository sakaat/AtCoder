// https://atcoder.jp/contests/abc127/submissions/8379991

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var r = input[0];
            var D = input[1];
            var x = input[2];

            var result = x;
            for (int i = 0; i < 10; i++)
            {
                result = r * result - D;
                Console.WriteLine(result);
            }
        }
    }
}
