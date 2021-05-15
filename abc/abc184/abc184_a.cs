// https://atcoder.jp/contests/abc184/submissions/19008473

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var a = input1[0];
        var b = input1[1];
        
        var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var c = input2[0];
        var d = input2[1];

        Console.WriteLine(a * d - b * c);
    }
}
