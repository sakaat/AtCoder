// https://atcoder.jp/contests/abc156/submissions/10293058

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = input[0];
            var K = input[1];

            var result = 0L;
            while (N > 0L)
            {
                N /= K;
                result++;
            }
            Console.WriteLine($"{result}");
        }
    }
}
