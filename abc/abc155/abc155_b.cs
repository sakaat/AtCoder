// https://atcoder.jp/contests/abc155/submissions/10162819

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var flag = true;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    if (A[i] % 3 != 0 && A[i] % 5 != 0)
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine(flag ? "APPROVED" : "DENIED");
        }
    }
}
