// https://atcoder.jp/contests/abc196/submissions/22557364

using System;

class Program
{
    static void Main()
    {
        var X = Console.ReadLine();
        if (X.Contains('.'))
        {
            Console.WriteLine(X.Substring(0, X.IndexOf('.')));
        }
        else
        {
            Console.WriteLine(X);
        }
    }
}
