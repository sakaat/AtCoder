// https://atcoder.jp/contests/abc167/submissions/13103957

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
        var K = input[3];

        if (A >= K)
        {
            Console.WriteLine(K);
        }
        else if (A + B >= K)
        {
            Console.WriteLine(A);
        }
        else
        {
            Console.WriteLine(A - (K - A - B));
        }
    }
}
