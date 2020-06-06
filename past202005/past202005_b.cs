// https://atcoder.jp/contests/past202005-open/submissions/14073371

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input1[0];
        var M = input1[1];
        var Q = input1[2];

        var accepted = new List<int>[N];
        for (int i = 0; i < N; i++)
        {
            accepted[i] = new List<int>();
        }

        var solved = new int[M];
        for (int i = 0; i < Q; i++)
        {
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input2[0] == 1)
            {
                var result = 0;
                foreach (var ac in accepted[input2[1] - 1])
                {
                    result += N - solved[ac - 1];
                }
                Console.WriteLine(result);
            }
            else
            {
                solved[input2[2] - 1]++;
                accepted[input2[1] - 1].Add(input2[2]);
            }
        }
    }
}
