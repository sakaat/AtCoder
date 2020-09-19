// https://atcoder.jp/contests/abc179/submissions/16892897

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var result = 0;
        for (int i = 1; i < N; i++)
        {
            result += (N - 1) / i;
        }
        Console.WriteLine(result);
    }
}
