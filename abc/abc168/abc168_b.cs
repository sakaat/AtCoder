// https://atcoder.jp/contests/abc168/submissions/13388957

using System;

class Program
{
    static void Main()
    {
        var K = int.Parse(Console.ReadLine());
        var S = Console.ReadLine();

        if (S.Length > K)
        {
            Console.WriteLine(S.Substring(0, K) + "...");
        }
        else
        {
            Console.WriteLine(S);
        }
    }
}
