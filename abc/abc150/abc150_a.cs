// https://atcoder.jp/contests/abc150/submissions/9383953

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var K = input[0];
            var X = input[1];

            Console.WriteLine(K * 500 >= X ? "Yes" : "No");
        }
    }
}
