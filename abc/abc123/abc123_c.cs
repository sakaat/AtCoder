// https://atcoder.jp/contests/abc123/submissions/8450275

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = long.Parse(Console.ReadLine());
            var city = new long[5].Select(_ => long.Parse(Console.ReadLine())).ToArray();

            Console.WriteLine((long)Math.Ceiling((double)N / city.Min()) + 4);
        }
    }
}
