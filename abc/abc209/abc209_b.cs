// https://atcoder.jp/contests/abc209/submissions/24162655

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

        Console.WriteLine(A.Sum() - N / 2 <= X ? "Yes" : "No");
    }
}
