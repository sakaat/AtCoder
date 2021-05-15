// https://atcoder.jp/contests/abc185/submissions/22583473

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];
        var T = input[2];

        var n = N;
        var A = 0;
        var B = 0;
        var result = true;
        for (int i = 0; i < M; i++)
        {
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A = input2[0];
            n -= A - B;
            if (n <= 0)
            {
                result = false;
                break;
            }
            B = input2[1];
            if (n + B - A < N)
            {
                n += B - A;
            }
            else
            {
                n = N;
            }
        }
        if (n - T + B <= 0)
        {
            result = false;
        }
        Console.WriteLine(result ? "Yes" : "No");
    }
}
