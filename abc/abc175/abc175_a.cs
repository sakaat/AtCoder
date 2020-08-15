// https://atcoder.jp/contests/abc175/submissions/15961847

using System;

class Program
{
    static void Main()
    {
        var S = Console.ReadLine();

        var result = 0;
        switch (S)
        {
            case "SSS":
                result = 0;
                break;
            case "SSR":
            case "SRS":
            case "RSS":
            case "RSR":
                result = 1;
                break;
            case "SRR":
            case "RRS":
                result = 2;
                break;
            case "RRR":
                result = 3;
                break;
        }
        Console.WriteLine(result);
    }
}
