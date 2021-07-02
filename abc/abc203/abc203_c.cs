// https://atcoder.jp/contests/abc203/submissions/23917640

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        var AB = new long[N][];
        for (int i = 0; i < N; i++)
        {
            AB[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
        }
        var oAB = AB.OrderBy(x => x[0]).ToArray();

        for (int i = 0; i < N; i++)
        {
            if (oAB[i][0] > K)
            {
                break;
            }
            K += oAB[i][1];
        }
        Console.WriteLine(K);
    }
}