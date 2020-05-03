// https://atcoder.jp/contests/abc166/submissions/12786804

using System;

class Program
{
    static void Main()
    {
        var X = int.Parse(Console.ReadLine());

        static int Pow5(int x) => x * x * x * x * x;
        for (int i = -118; i <= 119; i++)
        {
            for (int j = -119; j <= 118; j++)
            {
                if (Pow5(i) - Pow5(j) == X)
                {
                    Console.WriteLine($"{i} {j}");
                    return;
                }
            }
        }
    }
}
