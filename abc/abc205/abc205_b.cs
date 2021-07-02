// https://atcoder.jp/contests/abc205/submissions/23917120

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(A);

        for (int i = 0; i < N; i++)
        {
            if (i + 1 != A[i])
            {
                Console.WriteLine("No");
                return;
            }
        }
        Console.WriteLine("Yes");
    }
}