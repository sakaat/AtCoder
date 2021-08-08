// https://atcoder.jp/contests/abc213/submissions/24897250

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = Console.ReadLine();
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var AS = A.Select((s, i) => (s, i)).ToArray();
        Array.Sort(AS);

        Console.WriteLine(AS[AS.Length - 2].i + 1);
    }
}
