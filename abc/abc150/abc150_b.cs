// https://atcoder.jp/contests/abc150/submissions/9389320

using System;
using System.Text.RegularExpressions;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = Console.ReadLine();
            var S = Console.ReadLine();

            var r = Regex.Matches(S, "ABC");
            Console.WriteLine(r.Count);
        }
    }
}
