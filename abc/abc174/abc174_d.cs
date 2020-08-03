// https://atcoder.jp/contests/abc174/submissions/15666603

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var S = Console.ReadLine();

        var l = 0;
        var r = N - 1;
        var result = 0;

        while (true)
        {
            if (r <= l)
            {
                break;
            }
            if (S[l] == 'R')
            {
                l++;
            }
            else if (S[r] == 'W')
            {
                r--;
            }
            else
            {
                l++;
                r--;
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
