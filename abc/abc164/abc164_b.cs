// https://atcoder.jp/contests/abc164/submissions/12399772

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var C = input[2];
        var D = input[3];

        var i = 0;
        while (A > 0 && C > 0)
        {
            if (i % 2 == 1)
            {
                A -= D;
            }
            else
            {
                C -= B;
            }
            i++;
        }
        Console.WriteLine(A <= 0 ? "No" : "Yes");
    }
}
