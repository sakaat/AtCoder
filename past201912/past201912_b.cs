// https://atcoder.jp/contests/past201912-open/submissions/9525206

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var A = new int[N];
            for (var i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 0; i < N - 1; i++)
            {
                var diff = A[i + 1] - A[i];
                if (diff > 0)
                {
                    Console.WriteLine($"up {diff}");
                }
                else if (diff < 0)
                {
                    Console.WriteLine($"down {-diff}");
                }
                else
                {
                    Console.WriteLine("stay");
                }
            }
        }
    }
}
