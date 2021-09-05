// https://atcoder.jp/contests/past202012-open/submissions/25625423

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var base36 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var N = int.Parse(Console.ReadLine());

        var result = string.Empty;
        while (N > 0)
        {
            result += base36[N % 36];
            N /= 36;
        }
        Console.WriteLine(result.Length > 0 ? string.Join("", result.Reverse()) : "0");
    }
}
