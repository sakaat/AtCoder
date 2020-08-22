// https://atcoder.jp/contests/abc176/submissions/16152795

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = Console.ReadLine().ToCharArray().Select(c => (int)(c - '0')).ToArray();
        var sum = 0;
        for (int i = 0; i < N.Length; i++)
        {
            sum += N[i];
        }
        Console.WriteLine(sum % 9 == 0 ? "Yes" : "No");
    }
}
