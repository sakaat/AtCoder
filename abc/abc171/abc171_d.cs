// https://atcoder.jp/contests/abc171/submissions/14589933

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var Q = int.Parse(Console.ReadLine());

        var a = new long[100001];
        for (var i = 0; i < A.Length; i++)
        {
            a[A[i]]++;
        }
        var s = A.Sum();

        for (int i = 0; i < Q; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            s += (input[1] - input[0]) * a[input[0]];
            a[input[1]] += a[input[0]];
            a[input[0]] = 0;
            Console.WriteLine(s);
        }
    }
}
