// https://atcoder.jp/contests/abc215/submissions/25266541

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        var S = String.Concat(input[0].OrderBy(c => c));
        var K = int.Parse(input[1]);

        Console.WriteLine(Permutation(S).Distinct().Skip(K - 1).First());
    }

    static List<string> Permutation(string s)
    {
        if (s.Length == 1)
        {
            return new List<string>() { s };
        }
        var r = new List<string>();
        for (int i = 0; i < s.Length; i++)
        {
            foreach (var t in Permutation(s.Remove(i, 1)))
            {
                r.Add(s[i] + t);
            }
        }
        return r;
    }
}
