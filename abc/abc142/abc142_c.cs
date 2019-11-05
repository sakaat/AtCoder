// https://atcoder.jp/contests/abc142/submissions/7961125

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var result = new int[N];
        for (int i = 0; i < N; i++)
        {
            result[A[i] - 1] = i + 1;
        }
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write($"{result[i]} ");
        }
        Console.WriteLine(result[N - 1]);
    }
}
