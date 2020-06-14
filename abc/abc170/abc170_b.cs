// https://atcoder.jp/contests/abc170/submissions/14360675

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var X = input[0];
        var Y = input[1];

        for (int i = 0; i <= X; i++)
        {
            if (2 * i + 4 * (X - i) == Y)
            {
                Console.WriteLine("Yes");
                return;
            }
        }
        Console.WriteLine("No");
    }
}
