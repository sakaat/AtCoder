// https://atcoder.jp/contests/abc167/submissions/13103939

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var T = Console.ReadLine().Substring(0, S.Length);

        Console.WriteLine(S == T ? "Yes" : "No");
    }
}
