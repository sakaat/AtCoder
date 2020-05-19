// https://atcoder.jp/contests/abc168/submissions/13388935

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine()) % 10;
        if (N == 3)
        {
            Console.WriteLine("bon");
        }
        else if (N == 0 || N == 1 || N == 6 || N == 8)
        {
            Console.WriteLine("pon");
        }
        else
        {
            Console.WriteLine("hon");
        }
    }
}
