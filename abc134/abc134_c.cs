// https://atcoder.jp/contests/abc134/submissions/8260817

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var max1 = 0;
            var max2 = 0;
            var A = new int[N];
            for (var i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                if (max1 < A[i])
                {
                    max2 = max1;
                    max1 = A[i];
                }
                else if (max2 < A[i])
                {
                    max2 = A[i];
                }
            }

            for (var i = 0; i < N; i++)
            {
                if (A[i] == max1)
                {
                    Console.WriteLine(max2);
                }
                else
                {
                    Console.WriteLine(max1);
                }
            }
        }
    }
}
