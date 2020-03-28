// https://atcoder.jp/contests/abc160/submissions/11315018

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var X = long.Parse(Console.ReadLine());
            Console.WriteLine(1000 * (X / 500) + 5 * (X % 500 / 5));
        }
    }
}
