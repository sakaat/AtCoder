// https://atcoder.jp/contests/abc139/submissions/7252682

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var T = Console.ReadLine();

        var counter = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == T[i])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
