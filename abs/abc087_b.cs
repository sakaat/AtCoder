// https://atcoder.jp/contests/abs/submissions/7035868

using System;

class Program
{
    static void Main()
    {
        var A = int.Parse(Console.ReadLine());
        var B = int.Parse(Console.ReadLine());
        var C = int.Parse(Console.ReadLine());
        var X = int.Parse(Console.ReadLine());
        var result = 0;

        for (var a = 0; a <= A; a++)
        {
            for (var b = 0; b <= B; b++)
            {
                for (var c = 0; c <= C; c++)
                {
                    if (X == 500 * a + 100 * b + 50 * c)
                    {
                        result++;
                    }
                }
            }
        }

        Console.WriteLine($"{result}");
    }
}
