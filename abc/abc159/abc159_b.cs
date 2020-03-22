// https://atcoder.jp/contests/abc159/submissions/11108001

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var S = Console.ReadLine();
            var sr = new string(S.Reverse().ToArray());

            var s1 = S.Substring(0, (S.Length - 1) / 2);
            var s1r = new string(s1.Reverse().ToArray());

            var s2 = S.Substring((S.Length + 1) / 2);
            var s2r = new string(s2.Reverse().ToArray());

            if (S == sr && s1 == s1r && s2 == s2r)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
