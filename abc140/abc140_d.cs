// https://atcoder.jp/contests/abc140/submissions/7407168

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];
        var S = Console.ReadLine().ToCharArray();

        var index = 0;
        var j = 0;
        var c = S[0] == 'R' ? 'L' : 'R';
        for (var i = 0; i < K; i++)
        {
            index = Array.IndexOf(S, c, j);

            if (index == -1)
            {
                break;
            }
            j = index;
            while (S[j] != S[0])
            {
                S[j] = S[0];
                j++;
                if (j >= S.Length)
                {
                    break;
                }
            }
        }

        var result = 0;
        for (int i = 1; i < N; i++)
        {
            if (S[i - 1] == S[i])
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
