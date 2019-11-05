// https://atcoder.jp/contests/abc139/submissions/7264299

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var H = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var temp = 0;
        var result = 0;

        for (int i = 0; i < N - 1; i++)
        {
            if (H[i + 1] <= H[i])
            {
                temp++;
                if (temp > result)
                {
                    result = temp;
                }
            }
            else
            {
                temp = 0;
            }
        }
        Console.WriteLine(result);
    }
}
