// https://atcoder.jp/contests/abc210/submissions/24374794

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var A = input[1];
        var X = input[2];
        var Y = input[3];

        Console.WriteLine(N <= A ? N * X : A * X + (N - A) * Y);
    }
}
