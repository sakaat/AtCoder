// https://atcoder.jp/contests/abs/submissions/7035834

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var result = 0;

        while (true)
        {
            if (A.Any(x => x % 2 != 0))
            {
                break;
            }
            A = A.Select(x => x / 2).ToArray();
            result++;
        }

        Console.WriteLine($"{result}");
    }
}
