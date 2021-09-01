// https://atcoder.jp/contests/abc216/submissions/25507419

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var result = string.Empty;

        while (N > 0)
        {
            if (N % 2 == 0)
            {
                result += "B";
                N /= 2;
            }
            else
            {
                result += "A";
                N--;
            }
        }
        Console.WriteLine(string.Join("", result.Reverse()));
    }
}
