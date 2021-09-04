// https://atcoder.jp/contests/past202010-open/submissions/25548099

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

        if (A > B)
        {
            if (C > A)
            {
                Console.WriteLine("A");
            }
            else if (B > C)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }
        }
        else
        {
            if (A > C)
            {
                Console.WriteLine("A");
            }
            else if (C > B)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }
        }
    }
}
