// https://atcoder.jp/contests/abc163/submissions/12145128

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var b = new Dictionary<int, int>();
        for (var i = 0; i < A.Length; i++)
        {
            if (b.ContainsKey(A[i]))
            {
                b[A[i]]++;
            }
            else
            {
                b.Add(A[i], 1);
            }
        }

        for (var i = 1; i < N + 1; i++)
        {
            if (b.ContainsKey(i))
            {
                Console.WriteLine(b[i]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
