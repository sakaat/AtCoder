// https://atcoder.jp/contests/abc122/submissions/9265582

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var c = new Dictionary<char, char>()
            {
                {'A', 'T'},
                {'T', 'A'},
                {'G', 'C'},
                {'C', 'G'}
            };

            var b = Console.ReadLine().ToCharArray();

            Console.WriteLine(c[b[0]]);
        }
    }
}
