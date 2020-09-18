// https://atcoder.jp/contests/abc115/submissions/16817232

using System;

class Program
{
    static void Main()
    {
        var d = "Christmas";
        switch (int.Parse(Console.ReadLine()))
        {
            case 24:
                d += " Eve";
                break;
            case 23:
                d += " Eve Eve";
                break;
            case 22:
                d += " Eve Eve Eve";
                break;
        }
        Console.WriteLine(d);
    }
}
