// https://atcoder.jp/contests/abc198/submissions/22651101

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = Console.ReadLine();

        var result = false;
        for (int i = 0; i <= 10; i++)
        {
            if (N == string.Concat(N.Reverse()))
            {
                result = true;
                break;
            }
            N = "0" + N;
        }
        Console.WriteLine(result ? "Yes" : "No");
    }
}
