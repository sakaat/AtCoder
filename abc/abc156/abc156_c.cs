// https://atcoder.jp/contests/abc156/submissions/10293085

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var X = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var p = (long)Math.Round(X.Average());

            Console.WriteLine($"{X.Select(x => (x - p) * (x - p)).Sum()}");
        }
    }
}
