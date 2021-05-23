// https://atcoder.jp/contests/abc202/submissions/22849019

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine().ToCharArray();
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == '6')
            {
                S[i] = '9';
            }
            else if (S[i] == '9')
            {
                S[i] = '6';
            }
        }
        Console.WriteLine(string.Concat(S.Reverse()));
    }
}
