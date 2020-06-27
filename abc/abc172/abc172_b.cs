// https://atcoder.jp/contests/abc172/submissions/14779393

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var T = Console.ReadLine();

        Console.WriteLine(S.Zip(T, (s, t) => s != t).Count(b => b));
    }
}
