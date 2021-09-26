// https://atcoder.jp/contests/abc220/submissions/26179139

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var X = long.Parse(Console.ReadLine());

        var p = X / A.Sum();
        var sum = p * A.Sum();
        var result = p * N;

        foreach (var k in A)
        {
            sum += k;
            result++;
            if (sum > X)
            {
                Console.WriteLine(result);
                return;
            }
        }
    }
}
