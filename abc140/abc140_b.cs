// https://atcoder.jp/contests/abc140/submissions/7387602

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var C = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var previous = -1;
        var result = 0;
        for (int i = 0; i < N; i++)
        {
            result += B[A[i] - 1];
            if (previous + 1 == A[i])
            {
                result += C[previous - 1];
            }
            previous = A[i];
        }

        Console.WriteLine(result);
    }
}
