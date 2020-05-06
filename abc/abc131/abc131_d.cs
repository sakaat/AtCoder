// https://atcoder.jp/contests/abc131/submissions/12883543

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var AB = new int[N][];
        for (int i = 0; i < N; i++)
        {
            AB[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        Array.Sort(AB, (x, y) => x[1] - y[1]);

        var flag = true;
        var time = 0;
        for (int i = 0; i < N; i++)
        {
            if ((time += AB[i][0]) > AB[i][1])
            {
                flag = false;
                break;
            }
        }
        Console.WriteLine(flag ? "Yes" : "No");
    }
}
