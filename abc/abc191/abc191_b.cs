// https://atcoder.jp/contests/abc191/submissions/22576195

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var X = input[1];
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        foreach (var item in A)
        {
            if (item != X)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
