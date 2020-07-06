// https://atcoder.jp/contests/abc173/submissions/15019863

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var result = new int[4];
        for (int i = 0; i < N; i++)
        {
            var S = Console.ReadLine();
            switch (S)
            {
                case "AC":
                    result[0]++;
                    break;
                case "WA":
                    result[1]++;
                    break;
                case "TLE":
                    result[2]++;
                    break;
                case "RE":
                    result[3]++;
                    break;
            }
        }
        Console.WriteLine($"AC x {result[0]}");
        Console.WriteLine($"WA x {result[1]}");
        Console.WriteLine($"TLE x {result[2]}");
        Console.WriteLine($"RE x {result[3]}");
    }
}
