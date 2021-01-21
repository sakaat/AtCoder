// https://atcoder.jp/contests/abc182/submissions/18004191

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var gcdness = 0;
        var result = 0;
        for (int i = 2; i <= 1000; i++)
        {
            var s = A.Where(x => x % i == 0).Count();
            if (s >= gcdness)
            {
                gcdness = s;
                result = i;
            }
        }
        Console.WriteLine(result);
    }
}
