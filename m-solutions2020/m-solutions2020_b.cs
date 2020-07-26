// https://atcoder.jp/contests/m-solutions2020/submissions/15466443

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];
        var C = input[2];
        var K = int.Parse(Console.ReadLine());

        var count = 0;
        while (A >= B)
        {
            count++;
            B *= 2;
        }
        while (B >= C)
        {
            count++;
            C *= 2;
        }
        Console.WriteLine(count <= K ? "Yes" : "No");
    }
}
