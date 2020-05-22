// https://atcoder.jp/contests/past202004-open/submissions/13482915

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var a = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '.', };

        var S = Console.ReadLine();

        var result = 0;
        foreach (var c1 in a)
        {
            if (Regex.IsMatch(S, c1.ToString()))
            {
                result++;
            }
        }
        foreach (var c1 in a)
        {
            foreach (var c2 in a)
            {
                if (Regex.IsMatch(S, c1.ToString() + c2.ToString()))
                {
                    result++;
                }
            }
        }
        foreach (var c1 in a)
        {
            foreach (var c2 in a)
            {
                foreach (var c3 in a)
                {
                    if (Regex.IsMatch(S, c1.ToString() + c2.ToString() + c3.ToString()))
                    {
                        result++;
                    }
                }
            }
        }
        Console.WriteLine(result);
    }
}
