// https://atcoder.jp/contests/abc142/submissions/7960840

using System;

class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine("0.5");
        }
        else
        {
            Console.WriteLine((a / 2 + 1.0) / a);
        }
    }
}
