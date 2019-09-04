// https://atcoder.jp/contests/ttpc2019/submissions/7218520

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var S = new string[N];

        for (int i = 0; i < N; i++)
        {
            S[i] = Console.ReadLine();
        }

        for (int i = 0; i < N; i++)
        {
            if (Regex.IsMatch(S[i], ".*okyo.*ech.*"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
