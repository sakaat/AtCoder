// https://atcoder.jp/contests/abc195/submissions/22823678

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var W = input[2];

        var m = int.MaxValue;
        var M = 0;
        for (int i = 1; i <= 1000000; i++)
        {
            if (A * i <= 1000 * W && 1000 * W <= B * i)
            {
                if (i < m)
                {
                    m = i;
                }
                if (M < i)
                {
                    M = i;
                }
            }
        }
        Console.WriteLine(M > 0 ? $"{m} {M}" : "UNSATISFIABLE");
    }
}
