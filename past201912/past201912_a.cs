// https://atcoder.jp/contests/past201912-open/submissions/9524693
// https://atcoder.jp/contests/past201912-open/submissions/9524742

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var S = Console.ReadLine();
            var i = 0;
            var flag = int.TryParse(S, out i);
            Console.WriteLine(flag ? $"{2 * i}" : "error");
        }
    }
}
