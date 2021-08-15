// https://atcoder.jp/contests/abc214/submissions/25078048

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        if (1 <= N && N <= 125)
        {
            Console.WriteLine(4);
        }
        else if (126 <= N && N <= 211)
        {
            Console.WriteLine(6);
        }
        else
        {
            Console.WriteLine(8);
        }
    }
}
