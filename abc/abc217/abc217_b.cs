// https://atcoder.jp/contests/abc217/submissions/25617344

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = new string[3];
        for (int i = 0; i < 3; i++)
        {
            input[i] = Console.ReadLine();
        }

        var list = new string[4] { "ABC", "ARC", "AGC", "AHC" };
        Console.WriteLine(list.Except(input).First());
    }
}
