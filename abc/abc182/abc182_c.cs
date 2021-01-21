// https://atcoder.jp/contests/abc182/submissions/19553848

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = Console.ReadLine().ToCharArray();

        var a = new int[3];
        for (int i = 0; i < 3; i++)
        {
            a[i] = N.Count(x => int.Parse(x.ToString()) % 3 == i);
        }
        var result = 0;

        var c = (a[1] + 2 * a[2]) % 3;
        if (c == 0)
        {
            result = 0;
        }
        else if (c == 1)
        {
            if (a[1] > 0)
            {
                if (N.Length == 1)
                {
                    result = -1;
                }
                else
                {
                    result = 1;
                }
            }
            else
            {
                if (N.Length == 2)
                {
                    result = -1;
                }
                else
                {
                    result = 2;
                }
            }
        }
        else
        {
            if (a[2] > 0)
            {
                if (N.Length == 1)
                {
                    result = -1;
                }
                else
                {
                    result = 1;
                }
            }
            else
            {
                if (N.Length == 2)
                {
                    result = -1;
                }
                else
                {
                    result = 2;
                }
            }
        }

        Console.WriteLine(result);
    }
}
