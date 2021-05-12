// https://atcoder.jp/contests/abc192/submissions/22540512

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var result = true;
        for (int i = 0; i < S.Length; i++)
        {
            if (i % 2 == 0 && S[i].ToString() != S[i].ToString().ToLower())
            {
                result = false;
                break;
            }
            else if (i % 2 == 1 && S[i].ToString() != S[i].ToString().ToUpper())
            {
                result = false;
                break;
            }
        }
        Console.WriteLine(result ? "Yes" : "No");
    }
}
