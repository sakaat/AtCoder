// https://atcoder.jp/contests/abc150/submissions/9396735

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Replace(" ", "");
            var Q = Console.ReadLine().Replace(" ", "");

            var s = string.Empty;
            for (int i = 1; i < N + 1; i++)
            {
                s += i.ToString();
            }

            var l = Permutation(s);

            var a = 0;
            var b = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == P)
                {
                    a = i;
                }
                if (l[i] == Q)
                {
                    b = i;
                }
            }
            Console.WriteLine(Math.Abs(a - b));
        }

        static List<string> Permutation(string s)
        {
            if (s.Length == 1)
            {
                return new List<string>() { s };
            }
            var result = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                foreach (var t in Permutation(s.Remove(i, 1)))
                {
                    result.Add(s[i] + t);
                }
            }
            return result;
        }
    }
}
