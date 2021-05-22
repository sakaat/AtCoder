// https://atcoder.jp/contests/abc190/submissions/22819045

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var S = input[1];
        var D = input[2];
        for (int i = 0; i < N; i++)
        {
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input2[0] < S && input2[1] > D)
            {
                Console.WriteLine("Yes");
                return;
            }
        }
        Console.WriteLine("No");
    }
}
