// https://atcoder.jp/contests/abc135/submissions/8233164

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var B = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var result = 0L;
            for (int i = 0; i < N; i++)
            {
                if (B[i] > A[i])
                {
                    B[i] -= A[i];
                    result += A[i];
                    A[i] = 0;
                }
                else
                {
                    A[i] -= B[i];
                    result += B[i];
                    B[i] = 0;
                }

                if (B[i] > A[i + 1])
                {
                    B[i] -= A[i + 1];
                    result += A[i + 1];
                    A[i + 1] = 0;
                }
                else
                {
                    A[i + 1] -= B[i];
                    result += B[i];
                    B[i] = 0;
                }
            }
            Console.WriteLine(result);
        }
    }
}
