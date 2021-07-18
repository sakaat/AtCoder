// https://atcoder.jp/contests/abc210/submissions/24375204

using System;

class Program
{
    static void Main()
    {
        _ = Console.ReadLine();
        var S = Console.ReadLine();

        var i = 0;
        while (true)
        {
            if (S[i] == '1')
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Takahashi");
                }
                else
                {
                    Console.WriteLine("Aoki");
                }
                return;
            }
            i++;
        }
    }
}
