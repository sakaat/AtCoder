// https://atcoder.jp/contests/abc212/submissions/24718882

using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var X = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            X[i] = int.Parse(input[i].ToString());
        }
        var step = true;
        var same = true;

        for (int i = 0; i < X.Length - 1; i++)
        {
            if (X[i] != X[i + 1])
            {
                same = false;
            }
            if ((X[i] + 1) % 10 != X[i + 1])
            {
                step = false;
            }
        }
        Console.WriteLine(same || step ? "Weak" : "Strong");
    }
}
