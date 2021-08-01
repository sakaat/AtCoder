// https://atcoder.jp/contests/abc212/submissions/24718507

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];

        if (A > 0 && B == 0)
        {
            Console.WriteLine("Gold");
        }
        else if (A == 0 && B > 0)
        {
            Console.WriteLine("Silver");
        }
        else
        {
            Console.WriteLine("Alloy");
        }
    }
}
