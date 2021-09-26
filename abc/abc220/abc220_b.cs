// https://atcoder.jp/contests/abc220/submissions/26178986

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var K = long.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split().ToArray();
        var A = input[0];
        var B = input[1];

        Console.WriteLine(f(A, K) * f(B, K));
    }

    static long f(string s, long k)
    {
        var result = 0L;
        foreach (var c in s)
        {
            result *= k;
            result += long.Parse(c.ToString());
        }
        return result;
    }
}
