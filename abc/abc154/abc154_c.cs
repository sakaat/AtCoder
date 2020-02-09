// https://atcoder.jp/contests/abc154/submissions/9986703

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var set1 = new HashSet<string>();
            for (int i = 0; i < N; i++)
            {
                set1.Add(input[i].ToString());
            }

            Console.WriteLine(N == set1.Count ? "YES" : "NO");
        }
    }
}
