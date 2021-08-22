// https://atcoder.jp/contests/abc215/submissions/25265929

using System;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var result = -1;

        while (N > 0)
        {
            result++;
            N /= 2;
        }
        Console.WriteLine(result);
    }
}
