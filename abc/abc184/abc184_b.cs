// https://atcoder.jp/contests/abc184/submissions/22583222

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var X = input[1];
        var S = Console.ReadLine().ToCharArray();

        foreach (var s in S)
        {
            if (s == 'o')
            {
                X++;
            }
            else if (X > 0)
            {
                X--;
            }
        }
        Console.WriteLine(X);
    }
}
