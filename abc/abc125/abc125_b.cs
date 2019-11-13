// https://atcoder.jp/contests/abc125/submissions/8422748

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var V = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var C = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(V.Zip(C, (v, c) => (v - c)).Sum(x => x > 0 ? x : 0));
        }
    }
}
