// https://atcoder.jp/contests/past202004-open/submissions/13541330

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 1; i <= N; i++)
        {
            var c = 0;
            var n = A[i - 1];
            while (true)
            {
                c++;
                if (i == n)
                {
                    break;
                }
                n = A[n - 1];
            }
            Console.Write($"{c} ");
        }
    }
}
