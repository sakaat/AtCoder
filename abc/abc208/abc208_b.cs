// https://atcoder.jp/contests/abc208/submissions/23996687

using System;

class Program
{
    static void Main()
    {
        var P = int.Parse(Console.ReadLine());

        var coins = new int[10];
        coins[0] = 1;
        for (var i = 1; i < 10; i++)
        {
            coins[i] = coins[i - 1] * (i + 1);
        }

        var result = 0;
        for (var i = 9; i >= 0; i--)
        {
            while (P >= coins[i])
            {
                result++;
                P -= coins[i];
            }
        }
        Console.WriteLine(result);
    }
}
