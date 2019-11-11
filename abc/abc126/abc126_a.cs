// https://atcoder.jp/contests/abc126/submissions/8399455

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var K = input[1];

            var S = Console.ReadLine().ToCharArray();
            S[K - 1] = char.ToLower(S[K - 1]);
            Console.WriteLine(S);
        }
    }
}
