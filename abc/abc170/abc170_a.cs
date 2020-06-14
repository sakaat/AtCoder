// https://atcoder.jp/contests/abc170/submissions/14359946

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();
        Console.WriteLine(Array.IndexOf(input, "0") + 1);
    }
}
