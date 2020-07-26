// https://atcoder.jp/contests/m-solutions2020/submissions/15466723

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

        var money = 1000L;
        for (int i = 0; i < N - 1; i++)
        {
            money += A[i] < A[i + 1] ? (A[i + 1] - A[i]) * (money / A[i]) : 0;
        }
        Console.WriteLine(money);
    }
}
