// https://atcoder.jp/contests/abc169/submissions/13926350

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

        if (A.Contains(0L))
        {
            Console.WriteLine(0);
            return;
        }

        var result = 1L;
        foreach (var a in A)
        {
            var temp = result * a;
            if (temp < result || temp > 1000000000000000000)
            {
                Console.WriteLine(-1);
                return;
            }
            result *= a;
        }
        Console.WriteLine(result);
    }
}
