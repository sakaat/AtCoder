// https://atcoder.jp/contests/past202004-open/submissions/13444679

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var S = Console.ReadLine();
            Console.WriteLine(S.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key);
        }
    }
}
