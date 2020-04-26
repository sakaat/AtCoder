// https://atcoder.jp/contests/abc164/submissions/12398987

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var S = input[0];
        var W = input[1];

        if (S > W)
        {
            Console.WriteLine("safe");
        }
        else
        {
            Console.WriteLine("unsafe");
        }
    }
}
