// https://atcoder.jp/contests/past202010-open/submissions/25548198

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var X = input[0];
        var Y = input[1];

        if (Y == 0)
        {
            Console.WriteLine("ERROR");
            return;
        }

        var result = (double)(100 * X / Y) / 100;
        Console.WriteLine("{0:0.00}", result);
    }
}
