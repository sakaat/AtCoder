// https://atcoder.jp/contests/abc138/submissions/7037671

using System;

class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        var result = a >= 3200 ? s : "red";
        Console.WriteLine($"{result}");
    }
}
