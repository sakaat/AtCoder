// https://atcoder.jp/contests/abc221/submissions/26340577

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var N = Console.ReadLine();
        var listN = Permutation(N);

        var result = 0;
        for (int i = 0; i < listN.Count; i++)
        {
            var s = listN[i];
            for (int j = 1; j < s.Length; j++)
            {
                var num1 = int.Parse(s.Substring(0, s.Length - j));
                var num2 = int.Parse(s.Substring(s.Length - j));
                if (num1 * num2 > result)
                {
                    result = num1 * num2;
                }
            }
        }
        Console.WriteLine(result);
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
