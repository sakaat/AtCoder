// https://atcoder.jp/contests/abc165/submissions/12649774

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var K = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];

        if (A % K == 0 || A + (K - A % K) <= B)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("NG");
        }
    }
}
