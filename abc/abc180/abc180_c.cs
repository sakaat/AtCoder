// https://atcoder.jp/contests/abc180/submissions/17490989

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());

        var result = new List<long>();
        for (var i = 1L; i <= Math.Sqrt(N); i++)
        {
            if (N % i == 0)
            {
                result.Add(i);
                if (N / i != i)
                {
                    result.Add(N / i);
                }
            }
        }
        result.Sort();
        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }
}