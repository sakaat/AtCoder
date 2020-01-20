// https://atcoder.jp/contests/past201912-open/submissions/9638205

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var t = new int[N];
            var d = 0;
            for (int i = 0; i < N; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (++t[input - 1] == 2)
                {
                    d = input;
                }
            }

            if (d > 0)
            {
                Console.WriteLine($"{d} {Array.IndexOf(t, 0) + 1}");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
