// https://atcoder.jp/contests/abc201/submissions/22815290

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var ST = new Dictionary<string, int>();
        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            ST.Add(input[0], int.Parse(input[1]));
        }
        Console.WriteLine(ST.OrderByDescending(key => key.Value).Skip(1).Take(1).ToList()[0].Key);
    }
}
