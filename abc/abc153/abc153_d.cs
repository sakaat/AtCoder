// https://atcoder.jp/contests/abc153/submissions/9756128

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var H = long.Parse(Console.ReadLine());
            var l = Math.Floor(Math.Log(H) / Math.Log(2));

            Console.WriteLine(Math.Pow(2, l + 1) - 1);
        }
    }
}
