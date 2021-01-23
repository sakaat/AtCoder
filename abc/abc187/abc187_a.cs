// https://atcoder.jp/contests/abc187/submissions/19538256

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();
        var SA = input[0].ToCharArray().Sum(x => int.Parse(x.ToString()));
        var SB = input[1].ToCharArray().Sum(x => int.Parse(x.ToString()));

        Console.WriteLine(SA < SB ? SB : SA);
    }
}
