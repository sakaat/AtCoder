// https://atcoder.jp/contests/abc180/submissions/17490900

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var x = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var manhattan = 0.0;
        for (int i = 0; i < N; i++)
        {
            manhattan += Math.Abs(x[i]);
        }

        var temp = 0.0;
        for (int i = 0; i < N; i++)
        {
            temp += x[i] * x[i];
        }
        var euclidian = Math.Sqrt(temp);

        var chebyshev = 0.0;
        for (int i = 0; i < N; i++)
        {
            chebyshev = Math.Max(chebyshev, Math.Abs(x[i]));
        }

        Console.WriteLine(manhattan);
        Console.WriteLine(euclidian);
        Console.WriteLine(chebyshev);
    }
}