// https://atcoder.jp/contests/abc217/submissions/25617224

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();
        var S = input[0];
        var T = input[1];

        Console.WriteLine(String.Compare(S, T) <= 0 ? "Yes" : "No");
    }
}
