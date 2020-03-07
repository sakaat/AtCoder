// https://atcoder.jp/contests/abc158/submissions/10617339

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

            for (int i = 0; i <= 1000; i++)
            {
                if (Math.Floor(i * 0.08) == A && Math.Floor(i * 0.1) == B)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("-1");
        }
    }
}
