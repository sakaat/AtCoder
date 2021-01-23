// https://atcoder.jp/contests/abc188/submissions/19538742

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var B = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var result = 0;
        for (int i = 0; i < N; i++)
        {
            result += A[i] * B[i];
        }
        Console.WriteLine(result == 0 ? "Yes" : "No");
    }
}
