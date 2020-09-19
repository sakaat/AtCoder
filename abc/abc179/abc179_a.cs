// https://atcoder.jp/contests/abc179/submissions/16890242

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        Console.WriteLine(S + (S[S.Length - 1] == 's' ? "es" : "s"));
    }
}