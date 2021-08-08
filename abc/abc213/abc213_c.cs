// https://atcoder.jp/contests/abc213/submissions/24898230

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[2];

        var A = new int[N];
        var B = new int[N];
        for (int i = 0; i < N; i++)
        {
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A[i] = input2[0];
            B[i] = input2[1];
        }

        var AH = A.ToHashSet().OrderBy(a => a).ToArray();
        var BH = B.ToHashSet().OrderBy(b => b).ToArray();

        for (int i = 0; i < N; i++)
        {
            var a = Array.BinarySearch(AH, A[i]);
            var b = Array.BinarySearch(BH, B[i]);
            Console.WriteLine($"{a + 1} {b + 1}");
        }
    }
}
