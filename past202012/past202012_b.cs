// https://atcoder.jp/contests/past202012-open/submissions/25625164

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var S = Console.ReadLine();

        var T = string.Empty;
        for (int i = 0; i < N; i++)
        {
            T = T.Replace(S[i].ToString(), "");
            T += S[i];
        }
        Console.WriteLine(T);
    }
}
