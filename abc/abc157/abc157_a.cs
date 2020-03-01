// https://atcoder.jp/contests/abc157/submissions/10444919

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(N % 2 == 0 ? N / 2 : N / 2 + 1)}");
        }
    }
}
