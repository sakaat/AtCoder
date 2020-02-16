// https://atcoder.jp/contests/abc155/submissions/10162470

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var C = input[2];

            if ((A == B && B == C) || (A != B && B != C && C != A))
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
