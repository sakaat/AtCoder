// https://atcoder.jp/contests/abc179/submissions/16890189

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var D = new int[N][];
        for (int i = 0; i < N; i++)
        {
            D[i] = new int[2];
            D[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        var count = 0;
        var result = "No";
        for (int i = 0; i < N; i++)
        {
            if (D[i][0] == D[i][1])
            {
                count++;
            }
            else
            {
                count = 0;
            }
            if (count == 3)
            {
                result = "Yes";
                break;
            }
        }
        Console.WriteLine(result);
    }
}
