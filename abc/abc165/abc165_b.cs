// https://atcoder.jp/contests/abc165/submissions/12651452

using System;

class Program
{
    static void Main()
    {
        var X = long.Parse(Console.ReadLine());

        var m = 100L;
        var result = 0;
        while (m < X)
        {
            m += (long)(m * 0.01);
            result++;
        }
        Console.WriteLine(result);
    }
}
