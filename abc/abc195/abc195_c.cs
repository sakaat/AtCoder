// https://atcoder.jp/contests/abc195/submissions/22828495

using System;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var answer = 0L;
        if (N >= 1000)
        {
            answer += N - 999;
        }
        if (N >= 1000000)
        {
            answer += N - 999999;
        }
        if (N >= 1000000000)
        {
            answer += N - 999999999;
        }
        if (N >= 1000000000000)
        {
            answer += N - 999999999999;
        }
        if (N >= 1000000000000000)
        {
            answer += N - 999999999999999;
        }
        Console.WriteLine(answer);
    }
}
