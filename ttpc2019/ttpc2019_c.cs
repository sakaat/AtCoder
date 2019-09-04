// https://atcoder.jp/contests/ttpc2019/submissions/7224211

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var N = input[0];
        var X = input[1];

        var a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        if (a.Count(x => x == -1) == 0)
        {
            var X2 = a.Where(x => x != -1)
                .Aggregate(0, (x, next) => x ^ next);
            if (X != X2)
            {
                Console.WriteLine("-1");
                return;
            }
        }

        var Y = a.Where(x => x != -1)
            .Aggregate(X, (x, next) => x ^ next);

        var isFirst = true;
        var result = string.Empty;
        foreach (var ai in a)
        {
            if (ai == -1 && isFirst)
            {
                result += Y + " ";
                isFirst = false;
            }
            else if (ai == -1)
            {
                result += "0 ";
            }
            else
            {
                result += ai + " ";
            }
        }
        Console.WriteLine(result.TrimEnd());
    }
}
