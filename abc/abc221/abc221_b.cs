// https://atcoder.jp/contests/abc221/submissions/26339869

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();
        var T = Console.ReadLine();

        if (S == T)
        {
            Console.WriteLine("Yes");
            return;
        }

        var d1 = -1;
        var d2 = -1;
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] != T[i])
            {
                if (d1 < 0)
                {
                    d1 = i;
                    continue;
                }
                if (d2 < 0)
                {
                    d2 = i;
                    continue;
                }
                Console.WriteLine("No");
                return;
            }
        }

        if (d1 < 0 || d2 < 0)
        {
            Console.WriteLine("No");
            return;
        }

        if (Math.Abs(d1 - d2) == 1 && S[d1] == T[d2] && S[d2] == T[d1])
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
