// https://atcoder.jp/contests/abc120/submissions/16642658

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var K = input[2];

        var result = 0;
        var r = 0;
        for (var i = Math.Min(A, B); ; i--)
        {
            if (A % i == 0 && B % i == 0)
            {
                r++;
                if (K == r)
                {
                    result = i;
                    break;
                }
            }
        }
        Console.WriteLine(result);
    }
}
