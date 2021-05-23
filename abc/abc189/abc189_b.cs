// https://atcoder.jp/contests/abc189/submissions/22849138

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var X = input[1];

        var sum = 0;
        for (int i = 0; i < N; i++)
        {
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var V = input2[0];
            var P = input2[1];
            sum += V * P;
            if (sum > X * 100)
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}
