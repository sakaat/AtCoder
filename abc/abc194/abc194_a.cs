// https://atcoder.jp/contests/abc194/submissions/22543943

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var C = A + B;

        var result = 4;
        if (C >= 15 && B >= 8)
        {
            result = 1;
        }
        else if (C >= 10 && B >= 3)
        {
            result = 2;
        }
        else if (C >= 3)
        {
            result = 3;
        }
        Console.WriteLine(result);
    }
}
