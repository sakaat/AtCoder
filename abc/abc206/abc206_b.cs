// https://atcoder.jp/contests/abc206/submissions/24097677

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var money = 0;
        var result = 0;
        while (true)
        {
            money += result;
            if (money >= N)
            {
                Console.WriteLine(result);
                return;
            }
            result++;
        }
    }
}
