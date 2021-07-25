// https://atcoder.jp/contests/abc211/submissions/24524998

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var S = new string[4];
        for (int i = 0; i < 4; i++)
        {
            S[i] = Console.ReadLine();
        }
        Console.WriteLine(S.Distinct().Count() == 4 ? "Yes" : "No");
    }
}
