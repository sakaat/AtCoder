// https://atcoder.jp/contests/past202005-open/submissions/14073557

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var A = input[0];
        var R = input[1];
        var N = input[2];

        if (R == 1)
        {
            Console.WriteLine(A);
            return;
        }
        if (N >= 31)
        {
            Console.WriteLine("large");
            return;
        }
        var value = A * Math.Pow(R, N - 1);
        if (value > Math.Pow(10, 9))
        {
            Console.WriteLine("large");
        }
        else
        {
            Console.WriteLine(value);
        }
    }
}
