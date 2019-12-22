// https://atcoder.jp/contests/abc148/submissions/9072633

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (!A.Contains(1))
            {
                Console.WriteLine("-1");
                return;
            }

            var temp = 1;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == temp)
                {
                    temp++;
                }
            }
            Console.WriteLine(N - temp + 1);
        }
    }
}
