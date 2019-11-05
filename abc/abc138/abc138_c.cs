// https://atcoder.jp/contests/abc138/submissions/7037895

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var v = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
        Array.Sort(v);
        Array.Reverse(v);

        var len = v.Length;
        while (len > 1)
        {
            v[len - 2] = (v[len - 2] + v[len - 1]) / 2.0;
            len--;
        }
        Console.WriteLine($"{v[0]}");
    }
}
