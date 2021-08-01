// https://atcoder.jp/contests/abc212/submissions/24722150

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(A);
        var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(B);

        var x = 0;
        var y = 0;
        var result = int.MaxValue;
        while (x < N && y < M)
        {
            result = Math.Min(result, Math.Abs(A[x] - B[y]));
            _ = A[x] > B[y] ? y++ : x++;
        }
        Console.WriteLine(result);
    }
}
