// https://atcoder.jp/contests/abc170/submissions/14363134

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var X = input1[0];
        if (input1[1] == 0)
        {
            Console.ReadLine();
            Console.WriteLine(X);
            return;
        }

        var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var a = new bool[102];
        for (int i = 0; i < input2.Length; i++)
        {
            a[input2[i]] = true;
        }

        var ridx = X;
        while (a[ridx])
        {
            ridx++;
        }
        var lidx = X;
        while (a[lidx])
        {
            lidx--;
        }

        Console.WriteLine((X - lidx) > (ridx - X) ? ridx : lidx);
    }
}
