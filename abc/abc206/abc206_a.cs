// https://atcoder.jp/contests/abc206/submissions/23923629

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var z = N * 108 / 100;

        var result = string.Empty;
        if (z < 206)
        {
            result = "Yay!";
        }
        else if (z == 206)
        {
            result = "so-so";
        }
        else
        {
            result = ":(";
        }
        Console.WriteLine(result);
    }
}
