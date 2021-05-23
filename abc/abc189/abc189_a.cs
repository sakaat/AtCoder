// https://atcoder.jp/contests/abc189/submissions/19682778

using System;

class Program
{
    static void Main()
    {
        var C = Console.ReadLine();
        Console.WriteLine(C[0] == C[1] && C[1] == C[2] ? "Won" : "Lost");
    }
}
