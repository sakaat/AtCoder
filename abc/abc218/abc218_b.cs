// https://atcoder.jp/contests/abc218/submissions/25818791

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var P = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < 26; i++)
        {
            Console.Write((char)('a' + P[i] - 1));
        }
    }
}
