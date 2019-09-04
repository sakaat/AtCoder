// https://atcoder.jp/contests/ttpc2019/submissions/7218095

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        var A = input[0];
        var B = input[1];
        var T = input[2];

        if ((T - B) % (B - A) == 0)
        {
            Console.WriteLine($"{T}");
        }
        else
        {
            Console.WriteLine($"{T + B - A - (T - B) % (B - A)}");
        }
    }
}
