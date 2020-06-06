// https://atcoder.jp/contests/past202005-open/submissions/14071541

using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        var t = Console.ReadLine();

        if (s == t)
        {
            Console.WriteLine("same");
        }
        else if (s.ToLower() == t.ToLower())
        {
            Console.WriteLine("case-insensitive");
        }
        else
        {
            Console.WriteLine("different");
        }
    }
}
