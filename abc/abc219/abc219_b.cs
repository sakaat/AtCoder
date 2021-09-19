// https://atcoder.jp/contests/abc219/submissions/25973408

using System;

class Program
{
    static void Main()
    {
        var S = new string[3];
        for (int i = 0; i < S.Length; i++)
        {
            S[i] = Console.ReadLine();
        }
        var T = Console.ReadLine();

        for (int i = 0; i < T.Length; i++)
        {
            Console.Write(S[int.Parse(T[i].ToString()) - 1]);
        }
    }
}
