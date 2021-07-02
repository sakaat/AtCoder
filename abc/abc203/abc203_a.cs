// https://atcoder.jp/contests/abc203/submissions/23082507

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var a = input[0];
        var b = input[1];
        var c = input[2];

        var result = 0;
        if (a == b)
        {
            result = c;
        }
        else if (b == c)
        {
            result = a;
        }
        else if (c == a)
        {
            result = b;
        }
        Console.WriteLine(result);
    }
}