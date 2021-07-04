// https://atcoder.jp/contests/abc207/submissions/23996820

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var C = input[2];
        var D = input[3];

        var b = A;
        var r = 0L;
        for (int i = 0; i < A; i++)
        {
            b += B;
            r += C;
            if (b <= D * r)
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}
