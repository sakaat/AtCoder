// https://atcoder.jp/contests/abc115/submissions/16817638

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];
        var h = new long[N];
        for (int i = 0; i < N; i++)
        {
            h[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(h);
        var result = h[N - 1];
        for (int i = 0; i < N - K + 1; i++)
        {
            if (result > h[i + K - 1] - h[i])
            {
                result = h[i + K - 1] - h[i];
            }
        }
        Console.WriteLine(result);
    }
}
