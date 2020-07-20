// https://atcoder.jp/contests/aising2020/submissions/15333600

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var result = 0;
        for (int i = 0; i < N; i++)
        {
            if ((i + 1) % 2 == 1 && a[i] % 2 == 1)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
