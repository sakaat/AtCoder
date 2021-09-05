// https://atcoder.jp/contests/past202012-open/submissions/25625008

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var result = "draw";

        if (S[0] == S[1] && S[1] == S[2]
            || S[1] == S[2] && S[2] == S[3]
            || S[2] == S[3] && S[3] == S[4])
        {
            result = S[2].ToString();
        }
        Console.WriteLine(result);
    }
}
