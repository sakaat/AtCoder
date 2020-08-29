// https://atcoder.jp/contests/abc177/submissions/16373897

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var T = Console.ReadLine();

        var result = 0;
        for (int i = 0; i <= S.Length - T.Length; i++)
        {
            var count = 0;
            for (int j = 0; j < T.Length; j++)
            {
                if (S[i + j] == T[j])
                {
                    count++;
                }
            }
            if (count > result)
            {
                result = count;
            }
        }
        Console.WriteLine(T.Length - result);
    }
}
