// https://atcoder.jp/contests/abc142/submissions/7960952

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var K = input[1];

        var h = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var result = 0;
        foreach (var item in h)
        {
            if (item >= K)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
