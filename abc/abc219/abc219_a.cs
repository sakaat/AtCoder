// https://atcoder.jp/contests/abc219/submissions/25973311

using System;

class Program
{
    static void Main()
    {
        var X = int.Parse(Console.ReadLine());

        var result = 0;
        if (X < 40)
        {
            result = 40 - X;
        }
        else if (X < 70)
        {
            result = 70 - X;
        }
        else if (X < 90)
        {
            result = 90 - X;
        }
        Console.WriteLine(result == 0 ? "expert" : result.ToString());
    }
}
