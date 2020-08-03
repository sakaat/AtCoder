// https://atcoder.jp/contests/abc174/submissions/15653049

using System;

class Program
{
    static void Main()
    {
        var K = int.Parse(Console.ReadLine());
        var q = 7 % K;
        var result = 1;

        while (true)
        {
            if (q == 0)
            {
                break;
            }
            if (K < result)
            {
                result = -1;
                break;
            }
            q = (10 * q + 7) % K;
            result++;
        }
        Console.WriteLine(result);
    }
}
