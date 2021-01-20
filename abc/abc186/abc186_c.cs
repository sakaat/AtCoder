// https://atcoder.jp/contests/abc186/submissions/19008018

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var result = 0;
        for (int i = 1; i <= N; i++)
        {
            if (i.ToString().Contains("7") || Convert.ToString(i, 8).Contains("7"))
            {
                continue;
            }
            result++;
        }
        Console.WriteLine(result);
    }
}
